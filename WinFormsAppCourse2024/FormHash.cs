using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCourse2024
{
    public partial class FormHash : Form
    {
        public FormHash()
        {
            InitializeComponent();

        }

        static string GetHashString(string input, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

            var userInput = textBoxPlainText.Text;

            // Genera e visualizza gli hash per diversi algoritmi di hash
            textBoxMD5.Text = GetHashString(userInput, new MD5CryptoServiceProvider());
            textBoxSHA1.Text = GetHashString(userInput, new SHA1CryptoServiceProvider());
            textBoxSHA256.Text = GetHashString(userInput, new SHA256CryptoServiceProvider());
            textBoxSHA512.Text = GetHashString(userInput, new SHA512CryptoServiceProvider());

        }
    }
}
