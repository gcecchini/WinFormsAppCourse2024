using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCourse2024
{
    public partial class FormPow : Form
    {
        public FormPow()
        {
            InitializeComponent();
        }

        private void textBoxExponent_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            BigInteger baseValue = BigInteger.Parse(textBoxBase.Text);
            BigInteger exponent = BigInteger.Parse(textBoxExponent.Text);
            BigInteger modulus = BigInteger.Parse(textBoxModulus.Text);

            textBoxResult.Text = ModPower(baseValue, exponent, modulus).ToString();
        }

        static BigInteger ModPower(BigInteger baseValue, BigInteger exponent, BigInteger modulus) {

            BigInteger result = 1;
            baseValue = baseValue % modulus;

            while (exponent > 0)
            {

                if (exponent % 2 == 1)
                       result = (result * baseValue) % modulus;

                exponent = exponent / 2;
                baseValue = (baseValue * baseValue) % modulus;

            }

            return result;  
        }


    }
}
