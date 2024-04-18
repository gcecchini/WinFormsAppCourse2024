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
    public partial class FormDES : Form
    {
        public FormDES()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            bytes = ASCIIEncoding.ASCII.GetBytes(textBoxIV.Text);
            byte[] key = Encoding.UTF8.GetBytes(textBoxKey.Text);
            string plainText = textBoxPlainText.Text;

            byte[] encryptedBytes = EncryptStringToBytes(plainText, key);
            textBoxEncryptedString.Text = Convert.ToBase64String(encryptedBytes);
        }

        static byte[] bytes;

        static byte[] EncryptStringToBytes(string plainText, byte[] key)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = key;
                //des.IV = bytes;
                //des.GenerateIV(); // Genera l'IV (Initialization Vector)
                //des.Mode = CipherMode.ECB;


                // Crea un oggetto per la trasformazione di cifratura
                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);

                // Crea il flusso di memoria per memorizzare i dati cifrati
                using (System.IO.MemoryStream msEncrypt = new System.IO.MemoryStream())
                {
                    // Crea il flusso di cifratura
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // Scrive i dati cifrati nel flusso
                        using (System.IO.StreamWriter swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    // Restituisce i dati cifrati come array di byte
                    return msEncrypt.ToArray();
                }
            }
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] key)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = key;
                //des.IV = bytes;
                //des.Mode = CipherMode.ECB;
                //des.GenerateIV(); // Genera l'IV (Initialization Vector)

                // Crea un oggetto per la trasformazione di decifrazione
                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);

                // Crea il flusso di memoria per memorizzare i dati decifrati
                using (System.IO.MemoryStream msDecrypt = new System.IO.MemoryStream(cipherText))
                {
                    // Crea il flusso di decifrazione
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        // Legge i dati decifrati dal flusso e li memorizza in una stringa
                        using (System.IO.StreamReader srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }




        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] key = Encoding.UTF8.GetBytes(textBoxKey.Text);
            byte[] encryptedBytes = Convert.FromBase64String(textBoxEncryptedString.Text);

            textBoxDecryptedString.Text = DecryptStringFromBytes(encryptedBytes, key);
        }

        private void buttonFindKey_Click(object sender, EventArgs e)
        {

            var byteCombinations = GetAllByteCombinations(4);

        }


        public static byte[][] GetAllByteCombinations(int byteCount)
        {
            if (byteCount < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(byteCount), "byteCount deve essere maggiore o uguale a 1");
            }

            // Crea un array di byte vuoto con la dimensione specificata
            var bytes = new byte[byteCount];

            // Crea un elenco per memorizzare le combinazioni
            var combinations = new List<byte[]>();

            // Funzione ricorsiva per generare combinazioni
            GenerateCombinations(bytes, 0, combinations);

            return combinations.ToArray();
        }


        private string findKey(string[] possibleKeys, string encryptedText, string plaintext)
        {

            string foundKey = "";

            foreach (string key in possibleKeys)
            {
                try
                {
                    // Decifra il testo con la chiave corrente
                    string decryptedText = DecryptStringFromBytes(Convert.FromBase64String(encryptedText), Encoding.UTF8.GetBytes(key));

                    if (decryptedText == plaintext)
                    {
                        foundKey = key;
                    }
                    break; // Interrompe l'iterazione una volta trovata la chiave corretta

                }
                catch (CryptographicException)
                {
                    // Ignora le eccezioni di decifrazione e passa alla prossima chiave
                }

            }

            return foundKey;
        }



        private static void GenerateCombinations(byte[] bytes, int index, List<byte[]> combinations)
        {
            // Se si è raggiunto l'ultimo byte, aggiungi la combinazione all'elenco
            if (index == bytes.Length)
            {
                var combination = new byte[bytes.Length];
                Array.Copy(bytes, combination, bytes.Length);
                combinations.Add(combination);
                return;
            }

            // Prova tutti i valori possibili per il byte corrente
            for (var i = 0; i < 256; i++)
            {
                bytes[index] = (byte)i;
                GenerateCombinations(bytes, index + 1, combinations);
            }
        }




    }
}
