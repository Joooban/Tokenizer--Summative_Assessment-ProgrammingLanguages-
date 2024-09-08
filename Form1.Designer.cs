namespace Tokenizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTextInput = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnTokenize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDelimeter = new System.Windows.Forms.ComboBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.clmTok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextInput
            // 
            this.lblTextInput.AutoSize = true;
            this.lblTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextInput.Location = new System.Drawing.Point(12, 50);
            this.lblTextInput.Name = "lblTextInput";
            this.lblTextInput.Size = new System.Drawing.Size(86, 20);
            this.lblTextInput.TabIndex = 0;
            this.lblTextInput.Text = "Enter Text:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(172, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "STRING TOKENIZER";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(16, 73);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(235, 150);
            this.txtInput.TabIndex = 3;
            // 
            // btnTokenize
            // 
            this.btnTokenize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTokenize.Location = new System.Drawing.Point(23, 310);
            this.btnTokenize.Name = "btnTokenize";
            this.btnTokenize.Size = new System.Drawing.Size(217, 30);
            this.btnTokenize.TabIndex = 6;
            this.btnTokenize.Text = "Tokenize";
            this.btnTokenize.UseVisualStyleBackColor = true;
            this.btnTokenize.Click += new System.EventHandler(this.btnTokenize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delimeter";
            // 
            // cbDelimeter
            // 
            this.cbDelimeter.FormattingEnabled = true;
            this.cbDelimeter.Location = new System.Drawing.Point(17, 267);
            this.cbDelimeter.Name = "cbDelimeter";
            this.cbDelimeter.Size = new System.Drawing.Size(234, 21);
            this.cbDelimeter.TabIndex = 8;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToOrderColumns = true;
            this.dgvOutput.AllowUserToResizeColumns = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTok,
            this.clmType,
            this.clmCompo});
            this.dgvOutput.Location = new System.Drawing.Point(311, 50);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOutput.Size = new System.Drawing.Size(417, 290);
            this.dgvOutput.TabIndex = 9;
            // 
            // clmTok
            // 
            this.clmTok.HeaderText = "Token";
            this.clmTok.Name = "clmTok";
            this.clmTok.ReadOnly = true;
            this.clmTok.Width = 125;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "Type";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Width = 125;
            // 
            // clmCompo
            // 
            this.clmCompo.HeaderText = "Components";
            this.clmCompo.Name = "clmCompo";
            this.clmCompo.ReadOnly = true;
            this.clmCompo.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 363);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.cbDelimeter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTokenize);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTextInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tokenizer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnTokenize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDelimeter;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTok;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompo;
    }
}

