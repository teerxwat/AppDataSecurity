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
    public partial class Form2 : Form
    {
        public byte[] abc;
        public byte[,] table;
        public byte[] result;
        public SaveFileDialog ch = new SaveFileDialog();

        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

            lbFrom2Change.Text = Global.GlobalVar ;
            //init abc
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            //save result to new file with the same extention
            String fileExt = Path.GetExtension(Global.GlobalVar);
            ch.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            if (ch.ShowDialog() == DialogResult.OK)
            {
                lbFrom2Change.Text = ch.FileName;
            }
        }

        private void btnEncryptionAction_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Global.GlobalVar))
            {
                MessageBox.Show("File does not exsit.");
                return;
            }
            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password emply. Please enter your password");
                return;
            }

            if ( tbPass.Text == tbPassCon.Text )
            {
                try
                {
                    byte[] fileContent = File.ReadAllBytes(Global.GlobalVar);
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
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];
                    }
                    File.WriteAllBytes(lbFrom2Change.Text, result);
                    MessageBox.Show("Encryption Completed...");
                }
                catch
                {
                    MessageBox.Show("File is in use. Close other program is usig this file and try again");
                    return;
                }
            }
            else if(tbPass.Text != tbPassCon.Text )
            {
                MessageBox.Show("Passwords do not match.");
            }
            else
            {
                MessageBox.Show("Enter Password...");
            }
            Form2.ActiveForm.Close();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void btnChange_MouseHover(object sender, EventArgs e)
        {
            btnChange.BackColor = Color.FromArgb(78, 0, 36);
            btnChange.ForeColor = Color.GreenYellow;
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            btnChange.ForeColor = Color.White;
        }

        private void btnEncryptionAction_MouseHover(object sender, EventArgs e)
        {
            btnEncryptionAction.BackColor = Color.FromArgb(78, 0, 36);
            btnEncryptionAction.ForeColor = Color.GreenYellow;
        }

        private void btnEncryptionAction_MouseLeave(object sender, EventArgs e)
        {
            btnEncryptionAction.ForeColor = Color.White;
        }
    }
}
