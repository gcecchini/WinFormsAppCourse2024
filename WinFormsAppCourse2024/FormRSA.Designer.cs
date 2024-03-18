namespace WinFormsAppCourse2024
{
    partial class FormRSA
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
            groupBoxBob = new GroupBox();
            buttonDecrypt = new Button();
            textBoxDecrypt = new TextBox();
            buttonKeyGenBob = new Button();
            groupBox2 = new GroupBox();
            textBoxD = new TextBox();
            label1 = new Label();
            textBoxModulusPriv = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBoxExponent = new TextBox();
            label5 = new Label();
            textBoxModulusPub = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            textBoxCipher = new TextBox();
            label4 = new Label();
            buttonEncrypt = new Button();
            textBoxClearText = new TextBox();
            label3 = new Label();
            groupBoxBob.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxBob
            // 
            groupBoxBob.Controls.Add(buttonDecrypt);
            groupBoxBob.Controls.Add(textBoxDecrypt);
            groupBoxBob.Controls.Add(buttonKeyGenBob);
            groupBoxBob.Controls.Add(groupBox2);
            groupBoxBob.Controls.Add(groupBox1);
            groupBoxBob.Location = new Point(18, 7);
            groupBoxBob.Name = "groupBoxBob";
            groupBoxBob.Size = new Size(1281, 303);
            groupBoxBob.TabIndex = 0;
            groupBoxBob.TabStop = false;
            groupBoxBob.Text = "Bob";
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(778, 186);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(100, 53);
            buttonDecrypt.TabIndex = 12;
            buttonDecrypt.Text = "Decrypt >";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // textBoxDecrypt
            // 
            textBoxDecrypt.Location = new Point(884, 186);
            textBoxDecrypt.Multiline = true;
            textBoxDecrypt.Name = "textBoxDecrypt";
            textBoxDecrypt.Size = new Size(339, 63);
            textBoxDecrypt.TabIndex = 11;
            // 
            // buttonKeyGenBob
            // 
            buttonKeyGenBob.Location = new Point(814, 32);
            buttonKeyGenBob.Name = "buttonKeyGenBob";
            buttonKeyGenBob.Size = new Size(159, 53);
            buttonKeyGenBob.TabIndex = 7;
            buttonKeyGenBob.Text = "Gen. Key";
            buttonKeyGenBob.UseVisualStyleBackColor = true;
            buttonKeyGenBob.Click += buttonKeyGenBob_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxD);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxModulusPriv);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(398, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Public key";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(15, 143);
            textBoxD.Multiline = true;
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(339, 63);
            textBoxD.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 125);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 8;
            label1.Text = "D";
            // 
            // textBoxModulusPriv
            // 
            textBoxModulusPriv.Location = new Point(15, 47);
            textBoxModulusPriv.Multiline = true;
            textBoxModulusPriv.Name = "textBoxModulusPriv";
            textBoxModulusPriv.Size = new Size(339, 63);
            textBoxModulusPriv.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 29);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Modulus";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxExponent);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxModulusPub);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(15, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Public key";
            // 
            // textBoxExponent
            // 
            textBoxExponent.Location = new Point(15, 143);
            textBoxExponent.Multiline = true;
            textBoxExponent.Name = "textBoxExponent";
            textBoxExponent.Size = new Size(339, 63);
            textBoxExponent.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 125);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Exponent";
            // 
            // textBoxModulusPub
            // 
            textBoxModulusPub.Location = new Point(15, 47);
            textBoxModulusPub.Multiline = true;
            textBoxModulusPub.Name = "textBoxModulusPub";
            textBoxModulusPub.Size = new Size(339, 63);
            textBoxModulusPub.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 29);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 6;
            label6.Text = "Modulus";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxCipher);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(buttonEncrypt);
            groupBox3.Controls.Add(textBoxClearText);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(56, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(857, 113);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alice";
            // 
            // textBoxCipher
            // 
            textBoxCipher.Location = new Point(457, 44);
            textBoxCipher.Multiline = true;
            textBoxCipher.Name = "textBoxCipher";
            textBoxCipher.Size = new Size(339, 63);
            textBoxCipher.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 26);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 11;
            label4.Text = "Ciphertext";
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(351, 44);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(100, 53);
            buttonEncrypt.TabIndex = 10;
            buttonEncrypt.Text = "Encrypt >";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // textBoxClearText
            // 
            textBoxClearText.Location = new Point(6, 44);
            textBoxClearText.Multiline = true;
            textBoxClearText.Name = "textBoxClearText";
            textBoxClearText.Size = new Size(339, 63);
            textBoxClearText.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Clear text";
            // 
            // FormRSA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxBob);
            Name = "FormRSA";
            Text = "FormRSA";
            groupBoxBob.ResumeLayout(false);
            groupBoxBob.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxBob;
        private GroupBox groupBox1;
        private TextBox textBoxExponent;
        private Label label5;
        private TextBox textBoxModulusPub;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox textBoxD;
        private Label label1;
        private TextBox textBoxModulusPriv;
        private Label label2;
        private Button buttonKeyGenBob;
        private GroupBox groupBox3;
        private TextBox textBoxClearText;
        private Label label3;
        private Button buttonEncrypt;
        private TextBox textBoxCipher;
        private Label label4;
        private Button buttonDecrypt;
        private TextBox textBoxDecrypt;
    }
}