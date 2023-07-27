using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDataSecurity
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
            this.TransparencyKey = Color.YellowGreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 489)
            {
                timer1.Stop();
                Form1 faa1 = new Form1();
                faa1.Show();
                this.Hide();
            }
        }
    }
}
