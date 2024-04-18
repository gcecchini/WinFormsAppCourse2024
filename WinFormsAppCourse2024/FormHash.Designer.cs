namespace WinFormsAppCourse2024
{
    partial class FormHash
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
            textBoxPlainText = new TextBox();
            buttonRun = new Button();
            textBoxMD5 = new TextBox();
            textBoxSHA1 = new TextBox();
            textBoxSHA256 = new TextBox();
            textBoxSHA512 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxPlainText
            // 
            textBoxPlainText.Location = new Point(25, 38);
            textBoxPlainText.Name = "textBoxPlainText";
            textBoxPlainText.Size = new Size(204, 23);
            textBoxPlainText.TabIndex = 0;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(91, 82);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(138, 39);
            buttonRun.TabIndex = 1;
            buttonRun.Text = "RUN";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // textBoxMD5
            // 
            textBoxMD5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMD5.Location = new Point(272, 128);
            textBoxMD5.Name = "textBoxMD5";
            textBoxMD5.Size = new Size(516, 23);
            textBoxMD5.TabIndex = 2;
            // 
            // textBoxSHA1
            // 
            textBoxSHA1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSHA1.Location = new Point(272, 157);
            textBoxSHA1.Name = "textBoxSHA1";
            textBoxSHA1.Size = new Size(516, 23);
            textBoxSHA1.TabIndex = 3;
            // 
            // textBoxSHA256
            // 
            textBoxSHA256.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSHA256.Location = new Point(272, 186);
            textBoxSHA256.Name = "textBoxSHA256";
            textBoxSHA256.Size = new Size(516, 23);
            textBoxSHA256.TabIndex = 4;
            // 
            // textBoxSHA512
            // 
            textBoxSHA512.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSHA512.Location = new Point(272, 215);
            textBoxSHA512.Name = "textBoxSHA512";
            textBoxSHA512.Size = new Size(516, 23);
            textBoxSHA512.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 136);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "MD5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 165);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 7;
            label2.Text = "SHA-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 194);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "SHA-256";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 218);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "SHA-512";
            // 
            // FormHash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSHA512);
            Controls.Add(textBoxSHA256);
            Controls.Add(textBoxSHA1);
            Controls.Add(textBoxMD5);
            Controls.Add(buttonRun);
            Controls.Add(textBoxPlainText);
            Name = "FormHash";
            Text = "FormHash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPlainText;
        private Button buttonRun;
        private TextBox textBoxMD5;
        private TextBox textBoxSHA1;
        private TextBox textBoxSHA256;
        private TextBox textBoxSHA512;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}