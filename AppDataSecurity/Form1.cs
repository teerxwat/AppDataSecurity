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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadIndex.Visible = true;
            panelDecrypy.Visible = false;
            panelEncryptions.Visible = false;
            panelAbout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            LoadIndex.Visible = false;
            panelEncryptions.Visible = true;
            panelDecrypy.Visible = false;
            panelAbout.Visible = false;
            TextShowTitle.Text = "Encryption";
            button5.BackColor = Color.FromArgb(240, 240, 242);
            button5.ForeColor = Color.FromArgb(78, 0, 36);
            button4.BackColor = Color.FromArgb(78, 0, 36);
            button4.ForeColor = Color.FromArgb(240, 240, 242);
            button3.BackColor = Color.FromArgb(78, 0, 36);
            button3.ForeColor = Color.FromArgb(240, 240, 242);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadIndex.Visible = false;
            panelEncryptions.Visible = false;
            panelDecrypy.Visible = true;
            panelAbout.Visible = false;
            TextShowTitle.Text = "Decryption";
            button4.BackColor = Color.FromArgb(240, 240, 242);
            button4.ForeColor = Color.FromArgb(78, 0, 36);
            button5.BackColor = Color.FromArgb(78, 0, 36);
            button5.ForeColor = Color.FromArgb(240, 240, 242);
            button3.BackColor = Color.FromArgb(78, 0, 36);
            button3.ForeColor = Color.FromArgb(240, 240, 242);
        }

        int mouseX = 0, mouseY = 0;
        int A, B;
        bool mouseDown;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            A = e.X;
            B = e.Y;
           if (mouseDown)
            {
                mouseX = MousePosition.X - 300;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Global.GlobalVar = tbEncShow.Text; 
            Form2 A = new Form2();
            Form1.ActiveForm.Hide();
            A.Show();
        }

        private void btnBrowsee_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbEncShow.Text = dialog.FileName;
                pictureShowImg.ImageLocation = tbEncShow.Text;
                if (tbEncShow.Text == null)
                {
                    lbStatusBro.ForeColor = Color.FromArgb(78, 0, 36);
                }
                else if (tbEncShow.Text != null)
                {
                    lbStatusBro.ForeColor = Color.LightGreen;
                }
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogDec = new OpenFileDialog();
            dialogDec.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialogDec.InitialDirectory = @"C:\";
            dialogDec.Title = "Please select an image file to encrypt.";

            if (dialogDec.ShowDialog() == DialogResult.OK)
            {
                tbDec.Text = dialogDec.FileName;
                picShowDec.ImageLocation = tbDec.Text;
                if (tbDec.Text == null)
                {
                    lbStatusBroDec.ForeColor = Color.FromArgb(78, 0, 36);
                }
                else if (tbDec.Text != null)
                {
                    lbStatusBroDec.ForeColor = Color.LightGreen;
                }
            }
        }

        private void btnDecrypy_Click(object sender, EventArgs e)
        {
            Global2.GlobalVar = tbDec.Text;
            Form3 B = new Form3();
            Form1.ActiveForm.Hide();
            B.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadIndex.Visible = false;
            panelAbout.Visible = true;
            panelEncryptions.Visible = false;
            panelDecrypy.Visible = false;
            TextShowTitle.Text = "About";
            button3.BackColor = Color.FromArgb(240, 240, 242);
            button3.ForeColor = Color.FromArgb(78, 0, 36);
            button5.BackColor = Color.FromArgb(78, 0, 36);
            button5.ForeColor = Color.FromArgb(240, 240, 242);
            button4.BackColor = Color.FromArgb(78, 0, 36);
            button4.ForeColor = Color.FromArgb(240, 240, 242);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadIndex.Visible = true;
            panelAbout.Visible = false;
            panelEncryptions.Visible = false;
            panelDecrypy.Visible = false;
            TextShowTitle.Text = "Encryption And Decryption";
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            A = e.X;
            B = e.Y;
            if (mouseDown)
            {
                mouseX = MousePosition.X - 300;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}