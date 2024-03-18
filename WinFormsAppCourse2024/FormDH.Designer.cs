namespace WinFormsAppCourse2024
{
    partial class FormDH
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
            groupBox1 = new GroupBox();
            textBoxSecretAlice = new TextBox();
            label3 = new Label();
            buttonKeyGenAlice = new Button();
            textBoxPublicAlice = new TextBox();
            label2 = new Label();
            textBoxPrivateAlice = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxSecretBob = new TextBox();
            label4 = new Label();
            buttonKeyGenBob = new Button();
            textBoxPublicBob = new TextBox();
            label5 = new Label();
            textBoxPrivateBob = new TextBox();
            label6 = new Label();
            buttonSecret = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxSecretAlice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonKeyGenAlice);
            groupBox1.Controls.Add(textBoxPublicAlice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxPrivateAlice);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 397);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alice";
            // 
            // textBoxSecretAlice
            // 
            textBoxSecretAlice.Location = new Point(6, 299);
            textBoxSecretAlice.Multiline = true;
            textBoxSecretAlice.Name = "textBoxSecretAlice";
            textBoxSecretAlice.Size = new Size(385, 63);
            textBoxSecretAlice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 281);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Secret shared";
            // 
            // buttonKeyGenAlice
            // 
            buttonKeyGenAlice.Location = new Point(102, 221);
            buttonKeyGenAlice.Name = "buttonKeyGenAlice";
            buttonKeyGenAlice.Size = new Size(159, 53);
            buttonKeyGenAlice.TabIndex = 6;
            buttonKeyGenAlice.Text = "Gen. Key";
            buttonKeyGenAlice.UseVisualStyleBackColor = true;
            buttonKeyGenAlice.Click += buttonKeyGenAlice_Click;
            // 
            // textBoxPublicAlice
            // 
            textBoxPublicAlice.Location = new Point(6, 139);
            textBoxPublicAlice.Multiline = true;
            textBoxPublicAlice.Name = "textBoxPublicAlice";
            textBoxPublicAlice.Size = new Size(385, 63);
            textBoxPublicAlice.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 121);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Public key";
            // 
            // textBoxPrivateAlice
            // 
            textBoxPrivateAlice.Location = new Point(6, 43);
            textBoxPrivateAlice.Multiline = true;
            textBoxPrivateAlice.Name = "textBoxPrivateAlice";
            textBoxPrivateAlice.Size = new Size(385, 63);
            textBoxPrivateAlice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Private key";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxSecretBob);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(buttonKeyGenBob);
            groupBox2.Controls.Add(textBoxPublicBob);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxPrivateBob);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(606, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 397);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bob";
            // 
            // textBoxSecretBob
            // 
            textBoxSecretBob.Location = new Point(6, 299);
            textBoxSecretBob.Multiline = true;
            textBoxSecretBob.Name = "textBoxSecretBob";
            textBoxSecretBob.Size = new Size(385, 63);
            textBoxSecretBob.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 281);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "Secret shared";
            // 
            // buttonKeyGenBob
            // 
            buttonKeyGenBob.Location = new Point(102, 221);
            buttonKeyGenBob.Name = "buttonKeyGenBob";
            buttonKeyGenBob.Size = new Size(159, 53);
            buttonKeyGenBob.TabIndex = 6;
            buttonKeyGenBob.Text = "Gen. Key";
            buttonKeyGenBob.UseVisualStyleBackColor = true;
            buttonKeyGenBob.Click += buttonKeyGenBob_Click;
            // 
            // textBoxPublicBob
            // 
            textBoxPublicBob.Location = new Point(6, 139);
            textBoxPublicBob.Multiline = true;
            textBoxPublicBob.Name = "textBoxPublicBob";
            textBoxPublicBob.Size = new Size(385, 63);
            textBoxPublicBob.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 121);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Public key";
            // 
            // textBoxPrivateBob
            // 
            textBoxPrivateBob.Location = new Point(6, 43);
            textBoxPrivateBob.Multiline = true;
            textBoxPrivateBob.Name = "textBoxPrivateBob";
            textBoxPrivateBob.Size = new Size(385, 63);
            textBoxPrivateBob.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 2;
            label6.Text = "Private key";
            // 
            // buttonSecret
            // 
            buttonSecret.Location = new Point(424, 182);
            buttonSecret.Name = "buttonSecret";
            buttonSecret.Size = new Size(159, 53);
            buttonSecret.TabIndex = 7;
            buttonSecret.Text = "Set Secret";
            buttonSecret.UseVisualStyleBackColor = true;
            buttonSecret.Click += buttonSecret_Click_1;
            // 
            // FormDH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 450);
            Controls.Add(buttonSecret);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormDH";
            Text = "FormDH";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxSecretAlice;
        private Label label3;
        private Button buttonKeyGenAlice;
        private TextBox textBoxPublicAlice;
        private Label label2;
        private TextBox textBoxPrivateAlice;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBoxSecretBob;
        private Label label4;
        private Button buttonKeyGenBob;
        private TextBox textBoxPublicBob;
        private Label label5;
        private TextBox textBoxPrivateBob;
        private Label label6;
        private Button buttonSecret;
    }
}