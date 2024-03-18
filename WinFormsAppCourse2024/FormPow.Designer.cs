namespace WinFormsAppCourse2024
{
    partial class FormPow
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
            label1 = new Label();
            textBoxBase = new TextBox();
            textBoxExponent = new TextBox();
            label2 = new Label();
            textBoxModulus = new TextBox();
            label3 = new Label();
            buttonCalc = new Button();
            textBoxResult = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Base";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(75, 28);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(211, 23);
            textBoxBase.TabIndex = 1;
            // 
            // textBoxExponent
            // 
            textBoxExponent.Location = new Point(75, 68);
            textBoxExponent.Name = "textBoxExponent";
            textBoxExponent.Size = new Size(211, 23);
            textBoxExponent.TabIndex = 3;
            textBoxExponent.TextChanged += textBoxExponent_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Exponent";
            // 
            // textBoxModulus
            // 
            textBoxModulus.Location = new Point(75, 106);
            textBoxModulus.Name = "textBoxModulus";
            textBoxModulus.Size = new Size(211, 23);
            textBoxModulus.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Modulus";
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(59, 161);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(164, 43);
            buttonCalc.TabIndex = 6;
            buttonCalc.Text = "Calculate";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(75, 246);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(211, 23);
            textBoxResult.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 249);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Result";
            // 
            // FormPow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(label4);
            Controls.Add(buttonCalc);
            Controls.Add(textBoxModulus);
            Controls.Add(label3);
            Controls.Add(textBoxExponent);
            Controls.Add(label2);
            Controls.Add(textBoxBase);
            Controls.Add(label1);
            Name = "FormPow";
            Text = "FormPow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxBase;
        private TextBox textBoxExponent;
        private Label label2;
        private TextBox textBoxModulus;
        private Label label3;
        private Button buttonCalc;
        private TextBox textBoxResult;
        private Label label4;
    }
}