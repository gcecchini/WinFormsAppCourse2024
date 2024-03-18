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

namespace WinFormsAppCourse2024
{
    public partial class FormDH : Form
    {
        public FormDH()
        {
            InitializeComponent();
        }

        ECDiffieHellmanCng alice = new ECDiffieHellmanCng();
        ECDiffieHellmanCng bob = new ECDiffieHellmanCng();

        byte[] alicePublicKey;
        byte[] bobPublicKey;

        private void AliceGenerateKey()
        {
            alicePublicKey = alice.PublicKey.ToByteArray();
            textBoxPublicAlice.Text = Convert.ToBase64String(alicePublicKey);
            textBoxPrivateAlice.Text = Convert.ToBase64String(alice.ExportECPrivateKey());
        }

        private void BobGenerateKey()
        {
            bobPublicKey = bob.PublicKey.ToByteArray();
            textBoxPublicBob.Text = Convert.ToBase64String(bobPublicKey);
            textBoxPrivateBob.Text = Convert.ToBase64String(bob.ExportECPrivateKey());
        }


        private void buttonKeyGenAlice_Click(object sender, EventArgs e)
        {
            AliceGenerateKey();
        }

        private void buttonKeyGenBob_Click(object sender, EventArgs e)
        {
            BobGenerateKey();
        }

        private void buttonSecret_Click_1(object sender, EventArgs e)
        {
            byte[] aliceSharedSecret = alice.DeriveKeyMaterial(CngKey.Import(bobPublicKey, CngKeyBlobFormat.EccPublicBlob));
            byte[] bobSharedSecret = bob.DeriveKeyMaterial(CngKey.Import(alicePublicKey, CngKeyBlobFormat.EccPublicBlob));


            textBoxSecretAlice.Text = Convert.ToBase64String(aliceSharedSecret);
            textBoxSecretBob.Text = Convert.ToBase64String(bobSharedSecret);
        }
    }
}
