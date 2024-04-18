namespace WinFormsAppCourse2024
{
    partial class FormDES
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
            label5 = new Label();
            textBoxDecryptedString = new TextBox();
            label4 = new Label();
            textBoxPlainText = new TextBox();
            buttonDecrypt = new Button();
            label3 = new Label();
            textBoxEncryptedString = new TextBox();
            buttonEncrypt = new Button();
            label2 = new Label();
            textBoxIV = new TextBox();
            label1 = new Label();
            textBoxKey = new TextBox();
            buttonFindKey = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 257);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 26;
            label5.Text = "Decrypted String";
            // 
            // textBoxDecryptedString
            // 
            textBoxDecryptedString.Location = new Point(232, 277);
            textBoxDecryptedString.Multiline = true;
            textBoxDecryptedString.Name = "textBoxDecryptedString";
            textBoxDecryptedString.Size = new Size(294, 48);
            textBoxDecryptedString.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 24;
            label4.Text = "Plain text";
            // 
            // textBoxPlainText
            // 
            textBoxPlainText.Location = new Point(12, 45);
            textBoxPlainText.Multiline = true;
            textBoxPlainText.Name = "textBoxPlainText";
            textBoxPlainText.Size = new Size(239, 48);
            textBoxPlainText.TabIndex = 23;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(317, 194);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(116, 43);
            buttonDecrypt.TabIndex = 22;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 25);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 21;
            label3.Text = "Encrypted String";
            // 
            // textBoxEncryptedString
            // 
            textBoxEncryptedString.Location = new Point(481, 45);
            textBoxEncryptedString.Multiline = true;
            textBoxEncryptedString.Name = "textBoxEncryptedString";
            textBoxEncryptedString.Size = new Size(294, 48);
            textBoxEncryptedString.TabIndex = 20;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(317, 45);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(116, 43);
            buttonEncrypt.TabIndex = 19;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 143);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 18;
            label2.Text = "IV";
            // 
            // textBoxIV
            // 
            textBoxIV.Location = new Point(264, 140);
            textBoxIV.Name = "textBoxIV";
            textBoxIV.Size = new Size(239, 23);
            textBoxIV.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 114);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 16;
            label1.Text = "Key";
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(264, 111);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(239, 23);
            textBoxKey.TabIndex = 15;
            // 
            // buttonFindKey
            // 
            buttonFindKey.Location = new Point(317, 359);
            buttonFindKey.Name = "buttonFindKey";
            buttonFindKey.Size = new Size(133, 45);
            buttonFindKey.TabIndex = 27;
            buttonFindKey.Text = "Find key";
            buttonFindKey.UseVisualStyleBackColor = true;
            buttonFindKey.Click += buttonFindKey_Click;
            // 
            // FormDES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFindKey);
            Controls.Add(label5);
            Controls.Add(textBoxDecryptedString);
            Controls.Add(label4);
            Controls.Add(textBoxPlainText);
            Controls.Add(buttonDecrypt);
            Controls.Add(label3);
            Controls.Add(textBoxEncryptedString);
            Controls.Add(buttonEncrypt);
            Controls.Add(label2);
            Controls.Add(textBoxIV);
            Controls.Add(label1);
            Controls.Add(textBoxKey);
            Name = "FormDES";
            Text = "FormDES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBoxDecryptedString;
        private Label label4;
        private TextBox textBoxPlainText;
        private Button buttonDecrypt;
        private Label label3;
        private TextBox textBoxEncryptedString;
        private Button buttonEncrypt;
        private Label label2;
        private TextBox textBoxIV;
        private Label label1;
        private TextBox textBoxKey;
        private Button buttonFindKey;
    }
}