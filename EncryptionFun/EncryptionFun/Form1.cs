using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class Form1 : Form
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblBasicCeasar.Text = BasicCeaser(3);
            lblSeperatedCeasar.Text = SeperatedCeaser(3, 4);
            lblBasicKey.Text = BasicKey();
            lbl2Dkey.Text = TwoDKey();
        }


        private string BasicCeaser(int shift)
        {
            string unencrypted = txtInput.Text.ToLower();
            string encrypted = "";

            for (int i = 0; i < unencrypted.Length; i++)
            {
                encrypted = encrypted + alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + shift)%27];  
            }

            return encrypted;
        }

        private string SeperatedCeaser(int shift1, int shift2)
        {
            string unencrypted = txtInput.Text.ToLower();
            string encrypted = "";

            for (int i = 0; i < unencrypted.Length; i++)
            {
                if (i % 2 == 0)
                {
                    encrypted = encrypted + alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + shift1)%27];
                }
                else
                {
                    encrypted = encrypted + alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + shift2)%27];
                }
            }
            return encrypted;
            

        }

        private string BasicKey()
        {
            string unencrypted = txtInput.Text.ToLower();
            string encrypted = "";
            string key = "charles";
            int x = 0;

            for (int i = 0; i < unencrypted.Length; i++)
            {
                if (x < 6)
                {
                    x++;
                }
                else
                {
                    x = 0;
                }
                    encrypted = encrypted + alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + Array.IndexOf(alphabet, key.ElementAt(x)))%27];
                


            
            }

            return encrypted;
        }

        private string TwoDKey()
        {
            string unencrypted = txtInput.Text.ToLower();
            string encrypted = "";
            char[][] key = new char[][] { new char[]{'o','w','e','n'}, new char[] { 'w','i','l','l'}, new char[] { 'm','i','k','e'}, new char[]{ 'b','i','l','l'} };

            for (int i = 0; i < unencrypted.Length; i++)
            {
                if (Array.IndexOf(alphabet, unencrypted[i]) > 20)
                {
                    encrypted += alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + Array.IndexOf(alphabet, key[0][i%4]))%27];
                }
                else if (Array.IndexOf(alphabet, unencrypted[i]) > 13)
                {
                    encrypted += alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + Array.IndexOf(alphabet, key[1][i % 4]))%27];
                }
                else if (Array.IndexOf(alphabet, unencrypted[i]) > 6)
                {
                    encrypted += alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + Array.IndexOf(alphabet, key[2][i % 4]))%27];
                }
                else
                {
                    encrypted += alphabet[(Array.IndexOf(alphabet, unencrypted.ElementAt(i)) + Array.IndexOf(alphabet, key[3][i % 4]))%27];
                }

            }


            return encrypted;
        }


    }
}
