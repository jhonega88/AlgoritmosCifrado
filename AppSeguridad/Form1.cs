using System.Security.Cryptography;
using System.Text;
using AppSeguridad.Algoritmos.RSA_Test;

namespace AppSeguridad
{
    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cifrar_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(txtplain.Text);
            encryptedtext = RSA_Test.Encryption(plaintext, RSA.ExportParameters(false), false);
            txtencrypt.Text = ByteConverter.GetString(encryptedtext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = RSA_Test.Decryption(encryptedtext,
            RSA.ExportParameters(true), false);
            txtdecrypt.Text = ByteConverter.GetString(decryptedtex);
        }
    }
}