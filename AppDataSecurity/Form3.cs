using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppDataSecurity
{
    public partial class Form3 : Form
    {
        public byte[] abc;
        public byte[,] table;
        public byte[] result;

        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height -= 7;
            if (panel1.Height >= 350)
            {
                timer1.Stop();
            }
        }

        private void BtnForm3Change_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dec = new SaveFileDialog();
            String fileExt = Path.GetExtension(Global2.GlobalVar);
            Dec.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            if (Dec.ShowDialog() == DialogResult.OK)
            {
                lbForm3Change.Text = Dec.FileName;
            }
        }

        private void btnFrom3Decrypt_Click(object sender, EventArgs e)
        {

            if (!File.Exists(Global2.GlobalVar))
            {
                MessageBox.Show("File does not exsit.");
                return;
            }
            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password emply. Please enter your password");
                return;
            }

            if (tbPass.Text == tbPassCon.Text)
            {
                // Get file content and key for encrypt/decrypt
                try
                {
                    byte[] fileContent = File.ReadAllBytes(lbForm3Change.Text);
                    byte[] passwordTmp = Encoding.ASCII.GetBytes(tbPass.Text);
                    byte[] keys = new byte[fileContent.Length];
                    for (int i = 0; i < fileContent.Length; i++)
                        keys[i] = passwordTmp[i % passwordTmp.Length];

                    //Encrypt
                    result = new byte[fileContent.Length];

                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;

                        for (int j = 0; j < 256; j++)
                        {
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                    File.WriteAllBytes(lbForm3Change.Text, result);
                    MessageBox.Show("Encryption Completed...");
                }
                catch
                {
                    MessageBox.Show("File is in use. Close other program is usig this file and try again");
                    return;
                }
            }
            else if (tbPass.Text != tbPassCon.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }
            else
            {
                MessageBox.Show("Enter Password...");
            }
            Form3.ActiveForm.Close();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            lbForm3Change.Text = Global2.GlobalVar;

            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
        }

        private void BtnForm3Change_MouseHover(object sender, EventArgs e)
        {
            BtnForm3Change.BackColor = Color.FromArgb(78, 0, 36);
            BtnForm3Change.ForeColor = Color.GreenYellow;
        }

        private void BtnForm3Change_MouseLeave(object sender, EventArgs e)
        {
            BtnForm3Change.ForeColor = Color.White;
        }

        private void btnFrom3Decrypt_MouseHover(object sender, EventArgs e)
        {
            btnFrom3Decrypt.BackColor = Color.FromArgb(78, 0, 36);
            btnFrom3Decrypt.ForeColor = Color.GreenYellow;
        }

        private void btnFrom3Decrypt_MouseLeave(object sender, EventArgs e)
        {
            btnFrom3Decrypt.ForeColor = Color.White;
        }
    }
}
