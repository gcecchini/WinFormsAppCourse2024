namespace WinFormsAppCourse2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPWR = new Button();
            buttonDH = new Button();
            buttonRSA = new Button();
            buttonHash = new Button();
            buttonDES = new Button();
            SuspendLayout();
            // 
            // buttonPWR
            // 
            buttonPWR.Location = new Point(27, 21);
            buttonPWR.Name = "buttonPWR";
            buttonPWR.Size = new Size(105, 75);
            buttonPWR.TabIndex = 0;
            buttonPWR.Text = "Power";
            buttonPWR.UseVisualStyleBackColor = true;
            buttonPWR.Click += button1_Click;
            // 
            // buttonDH
            // 
            buttonDH.Location = new Point(165, 21);
            buttonDH.Name = "buttonDH";
            buttonDH.Size = new Size(105, 75);
            buttonDH.TabIndex = 1;
            buttonDH.Text = "Diffie-Hellman";
            buttonDH.UseVisualStyleBackColor = true;
            buttonDH.Click += buttonDH_Click;
            // 
            // buttonRSA
            // 
            buttonRSA.Location = new Point(307, 21);
            buttonRSA.Name = "buttonRSA";
            buttonRSA.Size = new Size(105, 75);
            buttonRSA.TabIndex = 2;
            buttonRSA.Text = "RSA";
            buttonRSA.UseVisualStyleBackColor = true;
            buttonRSA.Click += buttonRSA_Click;
            // 
            // buttonHash
            // 
            buttonHash.Location = new Point(27, 163);
            buttonHash.Name = "buttonHash";
            buttonHash.Size = new Size(105, 75);
            buttonHash.TabIndex = 3;
            buttonHash.Text = "Hash";
            buttonHash.UseVisualStyleBackColor = true;
            buttonHash.Click += buttonHash_Click;
            // 
            // buttonDES
            // 
            buttonDES.Location = new Point(165, 163);
            buttonDES.Name = "buttonDES";
            buttonDES.Size = new Size(105, 75);
            buttonDES.TabIndex = 4;
            buttonDES.Text = "DES";
            buttonDES.UseVisualStyleBackColor = true;
            buttonDES.Click += buttonDES_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDES);
            Controls.Add(buttonHash);
            Controls.Add(buttonRSA);
            Controls.Add(buttonDH);
            Controls.Add(buttonPWR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPWR;
        private Button buttonDH;
        private Button buttonRSA;
        private Button buttonHash;
        private Button buttonDES;
    }
}
