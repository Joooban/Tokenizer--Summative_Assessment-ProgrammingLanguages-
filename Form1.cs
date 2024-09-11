using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tokenizer
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, char> predefinedDelimiters = new Dictionary<string, char>
        {
            { "Space", ' ' },
            { "Comma", ',' },
            { "Period", '.' },
            { "Exclamation", '!' },
            { "Question Mark", '?' },
            { "Hyphen", '-' },
            { "Slash", '/' }
        };
        public Form1()
        {
            InitializeComponent();
            foreach (var delimiter in predefinedDelimiters.Keys)
            {
                cbDelimeter.Items.Add(delimiter);
            }
            cbDelimeter.SelectedIndex = 5; // para si hyphen ang una magpakita instead of blank
        }

        private List<string> Tokenize(string text, char[] delimiters)
        {
            List<string> tokens = new List<string>();
            StringBuilder currentToken = new StringBuilder();
            bool isBuildingNumber = false;  // Flag to indicate if currently building a number token
            bool hasDecimalPoint = false;   // Flag to track if a decimal point has been encountered in a number
            bool isBuildingPunctuation = false;  // Flag for grouping punctuation

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                // Check if character is a delimiter
                if (delimiters.Contains(ch))
                {
                    if (currentToken.Length > 0)
                    {
                        tokens.Add(currentToken.ToString());
                        currentToken.Clear();
                        isBuildingNumber = false;
                        hasDecimalPoint = false;
                        isBuildingPunctuation = false;
                    }
                }
                // Check if the character is a space
                else if (char.IsWhiteSpace(ch))
                {
                    // Ignore spaces
                    continue;
                }
                // Check if character is part of a number (digits and at most one decimal point)
                else if (char.IsDigit(ch))
                {
                    currentToken.Append(ch);
                    isBuildingNumber = true;
                    isBuildingPunctuation = false;
                }
                else if (ch == '.' && isBuildingNumber && !hasDecimalPoint && i + 1 < text.Length && char.IsDigit(text[i + 1]))
                {
                    // Only treat the '.' as part of the number if it's followed by another digit
                    hasDecimalPoint = true;
                    currentToken.Append(ch);
                }
                // Check if token is alphanumeric (contains both letters and digits)
                else if (char.IsLetterOrDigit(ch))
                {
                    currentToken.Append(ch);
                    isBuildingPunctuation = false;
                }
                // Check if character is punctuation and should be grouped
                else if (char.IsPunctuation(ch))
                {
                    if (!isBuildingPunctuation)
                    {
                        if (currentToken.Length > 0)
                        {
                            tokens.Add(currentToken.ToString());
                            currentToken.Clear();
                        }
                        isBuildingPunctuation = true;
                    }
                    currentToken.Append(ch);  // Group punctuation characters
                }
                else
                {
                    // If we were building a token but hit a non-token character, finalize the current token
                    if (currentToken.Length > 0)
                    {
                        tokens.Add(currentToken.ToString());
                        currentToken.Clear();
                        isBuildingNumber = false;
                        hasDecimalPoint = false;
                        isBuildingPunctuation = false;
                    }

                    currentToken.Append(ch);
                }
            }

            // Add the last token if it's not empty
            if (currentToken.Length > 0)
            {
                tokens.Add(currentToken.ToString());
            }

            return tokens;
        }






        private string ClassifyToken(string token, char selectedDelimiter)
        {
            // Remove leading and trailing spaces from the token
            token = token.Trim();

            // Check for specific token types
            if (string.IsNullOrWhiteSpace(token))
                return "End of Line";

            if (token == "\n")
                return "End of Line";

            // Check if token is a single punctuation character from predefined delimiters
            if (token.Length == 1 && predefinedDelimiters.Values.Contains(token[0]))
                return "Punctuation";

            // Check if token consists only of letters
            if (token.All(char.IsLetter))
                return "Word";

            // Check if token consists only of digits
            if (token.All(char.IsDigit))
                return "Number";

            // Check if token contains both letters and digits (alphanumeric)
            if (token.Any(char.IsLetter) && token.Any(char.IsDigit))
                return "Alphanumeric";

            // Check if token is a valid number format (handles decimals)
            if (token.Contains('.') && token.Count(char.IsDigit) > 0 && token.Count(c => c == '.') <= 1)
                return "Number";

            if (token.All(char.IsPunctuation))
                return "Punctuation";

            // Default case for special characters
            return "Special Characters/Undefined";
        }


        private List<(string, string, List<char>)> BreakdownTokens(List<string> tokens, char selectedDelimiter)
        {
            // Good way to visualize : First Name, Family Name, Gender (M/F)
            List<(string, string, List<char>)> breakdown = new List<(string, string, List<char>)>();

            foreach (var token in tokens)
            {
                string tokenType = ClassifyToken(token, selectedDelimiter); // Pass the delimiter to classify

                // If the token is "\n", add no components
                if (token == "\n")
                    breakdown.Add((token, tokenType, new List<char>()));
                else
                    breakdown.Add((token, tokenType, token.ToList()));
            }

            return breakdown;
        }

        private void btnTokenize_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;

            // Get the selected delimiter from the ComboBox
            char selectedDelimiter = predefinedDelimiters[cbDelimeter.SelectedItem.ToString()];

            // Use the selected delimiter as a single-element array
            char[] delimiters = new char[] { selectedDelimiter };

            List<string> tokens = Tokenize(text, delimiters);
            var granularTokens = BreakdownTokens(tokens, selectedDelimiter);

            // Clear the DataGridView before displaying new results
            dgvOutput.Rows.Clear();

            // Responsible sa pag display
            foreach (var (token, tokenType, components) in granularTokens)
            {
                dgvOutput.Rows.Add(token, tokenType, string.Join(", ", components));
            }

            txtInput.Text = "";
        }
    }
}
