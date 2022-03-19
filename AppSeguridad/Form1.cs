using System.Security.Cryptography;
using System.Text;
using AppSeguridad.Algoritmos.RSA_Test;
using AppSeguridad.Algoritmos.Cesar;
using AppSeguridad.Algoritmos.MonoAlfabetico;
using System.Text.RegularExpressions;

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

        private void btn_cifraCesar_Click(object sender, EventArgs e)
        {
            int desplaza = 0;
            bool success = int.TryParse(txt_desplazamiento.Text, out desplaza);
            if (desplaza==0)
            {
                Random rnd = new Random();
                desplaza = rnd.Next(1, 13);
                txt_desplazamiento.Text = desplaza.ToString();
            }
            txt_cifradoCesar.Text = Cesar.cifrar(txt_textoCesar.Text, desplaza);
            txt_descifradoCesar.Text = "";
        }

        private void btn_descifraCesar_Click(object sender, EventArgs e)
        {
            int desplaza = 0;
            bool success = int.TryParse(txt_desplazamiento.Text, out desplaza);
            txt_descifradoCesar.Text = Cesar.descifrar(txt_cifradoCesar.Text, desplaza);
        }

        private void btn_cifrarMono_Click(object sender, EventArgs e)
        {
            txt_claveMono.Text = Regex.Replace(txt_claveMono.Text, @"\s", "");
            txt_cifradoMono.Text = MonoAlfabetico.cifrar(txt_textoMono.Text, txt_claveMono.Text) ;
        }

        private void btn_descifrarMono_Click(object sender, EventArgs e)
        {
            txt_claveMono.Text = Regex.Replace(txt_claveMono.Text, @"\s", "");
            txt_descifraMono.Text = MonoAlfabetico.Descifrar(txt_cifradoMono.Text, txt_claveMono.Text);
        }
    }
}
