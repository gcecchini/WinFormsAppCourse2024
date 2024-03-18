using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsAppCourse2024
{
    public partial class FormRSA : Form
    {
        public RSAParameters publicKey;
        private RSAParameters privateKey;

        byte[] encryptedData;

        public FormRSA()
        {
            InitializeComponent();

        }

        private void buttonKeyGenBob_Click(object sender, EventArgs e)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {

                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);

                textBoxModulusPub.Text = Convert.ToBase64String(publicKey.Modulus);
                textBoxExponent.Text = Convert.ToBase64String(publicKey.Exponent);

                textBoxModulusPriv.Text = Convert.ToBase64String(privateKey.Modulus);
                textBoxD.Text = Convert.ToBase64String(privateKey.D);

            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = textBoxClearText.Text;
            encryptedData = EncryptData(Encoding.UTF8.GetBytes(plainText), publicKey);
            textBoxCipher.Text = Convert.ToBase64String(encryptedData);
        }

        static byte[] EncryptData(byte[] dataToEncrypt, RSAParameters publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {

                rsa.ImportParameters(publicKey);
                return rsa.Encrypt(dataToEncrypt, true);
            }
        }

        static byte[] DecryptData(byte[] dataToDecrypt, RSAParameters privateKey)
        {
            
            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(privateKey);
            return rsa.Decrypt(dataToDecrypt, true);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] decryptedData = DecryptData(encryptedData, privateKey);
            textBoxDecrypt.Text = Encoding.UTF8.GetString(decryptedData);
        }

    }
}
