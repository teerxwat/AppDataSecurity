
namespace AppDataSecurity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelEncryptions = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.lbStatusBro = new System.Windows.Forms.Label();
            this.btnBrowsee = new System.Windows.Forms.Button();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.pictureShowImg = new System.Windows.Forms.PictureBox();
            this.tbEncShow = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDecrypy = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbStatusBroDec = new System.Windows.Forms.Label();
            this.btnDec = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.picShowDec = new System.Windows.Forms.PictureBox();
            this.tbDec = new System.Windows.Forms.TextBox();
            this.TextShowTitle = new System.Windows.Forms.Label();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadIndex = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelEncryptions.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowImg)).BeginInit();
            this.panelDecrypy.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowDec)).BeginInit();
            this.panelAbout.SuspendLayout();
            this.LoadIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnEnc);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 594);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(-15, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 32);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppDataSecurity.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(26, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAbout.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbout.Location = new System.Drawing.Point(12, 510);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(198, 57);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Decrypy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnc
            // 
            this.btnEnc.FlatAppearance.BorderSize = 0;
            this.btnEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEnc.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnc.Location = new System.Drawing.Point(12, 219);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(198, 57);
            this.btnEnc.TabIndex = 3;
            this.btnEnc.Text = "Encryption";
            this.btnEnc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(210, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 40);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 594);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel5.Location = new System.Drawing.Point(-15, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(626, 32);
            this.panel5.TabIndex = 4;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppDataSecurity.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(26, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 179);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("ONE DAY", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(12, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "About";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("ONE DAY", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(12, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "Decrypt";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("ONE DAY", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(12, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 57);
            this.button5.TabIndex = 3;
            this.button5.Text = "Encryption";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // panelEncryptions
            // 
            this.panelEncryptions.Controls.Add(this.button6);
            this.panelEncryptions.Controls.Add(this.lbStatusBro);
            this.panelEncryptions.Controls.Add(this.btnBrowsee);
            this.panelEncryptions.Controls.Add(this.metroPanel3);
            this.panelEncryptions.Controls.Add(this.pictureShowImg);
            this.panelEncryptions.Controls.Add(this.tbEncShow);
            this.panelEncryptions.Location = new System.Drawing.Point(243, 67);
            this.panelEncryptions.Name = "panelEncryptions";
            this.panelEncryptions.Size = new System.Drawing.Size(559, 499);
            this.panelEncryptions.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Orator Std", 10F);
            this.button6.Location = new System.Drawing.Point(22, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(527, 43);
            this.button6.TabIndex = 11;
            this.button6.Text = "Click to Encryption File";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbStatusBro
            // 
            this.lbStatusBro.AutoSize = true;
            this.lbStatusBro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbStatusBro.ForeColor = System.Drawing.Color.DarkRed;
            this.lbStatusBro.Location = new System.Drawing.Point(400, 403);
            this.lbStatusBro.Name = "lbStatusBro";
            this.lbStatusBro.Size = new System.Drawing.Size(23, 31);
            this.lbStatusBro.TabIndex = 4;
            this.lbStatusBro.Text = "•";
            // 
            // btnBrowsee
            // 
            this.btnBrowsee.Font = new System.Drawing.Font("Orator Std", 10F);
            this.btnBrowsee.Location = new System.Drawing.Point(429, 398);
            this.btnBrowsee.Name = "btnBrowsee";
            this.btnBrowsee.Size = new System.Drawing.Size(117, 36);
            this.btnBrowsee.TabIndex = 10;
            this.btnBrowsee.Text = "Browse";
            this.btnBrowsee.UseVisualStyleBackColor = true;
            this.btnBrowsee.Click += new System.EventHandler(this.btnBrowsee_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(19, 427);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(370, 3);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 33);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(370, 3);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // pictureShowImg
            // 
            this.pictureShowImg.Location = new System.Drawing.Point(3, 3);
            this.pictureShowImg.Name = "pictureShowImg";
            this.pictureShowImg.Size = new System.Drawing.Size(553, 369);
            this.pictureShowImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureShowImg.TabIndex = 7;
            this.pictureShowImg.TabStop = false;
            // 
            // tbEncShow
            // 
            this.tbEncShow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbEncShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.tbEncShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEncShow.Location = new System.Drawing.Point(22, 409);
            this.tbEncShow.Name = "tbEncShow";
            this.tbEncShow.Size = new System.Drawing.Size(362, 13);
            this.tbEncShow.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(210, -9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(626, 40);
            this.panel8.TabIndex = 3;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panelDecrypy
            // 
            this.panelDecrypy.Controls.Add(this.btnDecrypt);
            this.panelDecrypy.Controls.Add(this.lbStatusBroDec);
            this.panelDecrypy.Controls.Add(this.btnDec);
            this.panelDecrypy.Controls.Add(this.metroPanel1);
            this.panelDecrypy.Controls.Add(this.picShowDec);
            this.panelDecrypy.Controls.Add(this.tbDec);
            this.panelDecrypy.Location = new System.Drawing.Point(243, 67);
            this.panelDecrypy.Name = "panelDecrypy";
            this.panelDecrypy.Size = new System.Drawing.Size(559, 499);
            this.panelDecrypy.TabIndex = 12;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Orator Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(22, 447);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(527, 43);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Click to Decrypy File";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypy_Click);
            // 
            // lbStatusBroDec
            // 
            this.lbStatusBroDec.AutoSize = true;
            this.lbStatusBroDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbStatusBroDec.ForeColor = System.Drawing.Color.DarkRed;
            this.lbStatusBroDec.Location = new System.Drawing.Point(400, 403);
            this.lbStatusBroDec.Name = "lbStatusBroDec";
            this.lbStatusBroDec.Size = new System.Drawing.Size(23, 31);
            this.lbStatusBroDec.TabIndex = 4;
            this.lbStatusBroDec.Text = "•";
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Orator Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(429, 398);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(117, 36);
            this.btnDec.TabIndex = 10;
            this.btnDec.Text = "Browse";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(19, 427);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(370, 3);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 33);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(370, 3);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // picShowDec
            // 
            this.picShowDec.Location = new System.Drawing.Point(3, 3);
            this.picShowDec.Name = "picShowDec";
            this.picShowDec.Size = new System.Drawing.Size(553, 369);
            this.picShowDec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picShowDec.TabIndex = 7;
            this.picShowDec.TabStop = false;
            // 
            // tbDec
            // 
            this.tbDec.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.tbDec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDec.Font = new System.Drawing.Font("ONE DAY", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDec.Location = new System.Drawing.Point(22, 409);
            this.tbDec.Name = "tbDec";
            this.tbDec.Size = new System.Drawing.Size(362, 19);
            this.tbDec.TabIndex = 3;
            // 
            // TextShowTitle
            // 
            this.TextShowTitle.AutoSize = true;
            this.TextShowTitle.Font = new System.Drawing.Font("Yellowtail", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShowTitle.Location = new System.Drawing.Point(237, 47);
            this.TextShowTitle.Name = "TextShowTitle";
            this.TextShowTitle.Size = new System.Drawing.Size(413, 51);
            this.TextShowTitle.TabIndex = 13;
            this.TextShowTitle.Text = "Encryption and Decryption";
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.LoadIndex);
            this.panelAbout.Controls.Add(this.label3);
            this.panelAbout.Controls.Add(this.label2);
            this.panelAbout.Controls.Add(this.label1);
            this.panelAbout.Controls.Add(this.label4);
            this.panelAbout.Location = new System.Drawing.Point(243, 67);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(559, 500);
            this.panelAbout.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(300, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 11);
            this.label4.TabIndex = 3;
            this.label4.Text = "63543206064-1";
            // 
            // LoadIndex
            // 
            this.LoadIndex.BackColor = System.Drawing.Color.White;
            this.LoadIndex.Controls.Add(this.pictureBox1);
            this.LoadIndex.Location = new System.Drawing.Point(0, 0);
            this.LoadIndex.Name = "LoadIndex";
            this.LoadIndex.Size = new System.Drawing.Size(559, 500);
            this.LoadIndex.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::AppDataSecurity.Properties.Resources.bece0c797cb134aefb2cb836578c92491;
            this.pictureBox1.Location = new System.Drawing.Point(33, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teerawat Pinchai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ONE DAY", 8F);
            this.label2.Location = new System.Drawing.Point(300, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "0.0.0.1.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ONE DAY", 7F);
            this.label1.Location = new System.Drawing.Point(248, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "version";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::AppDataSecurity.Properties.Resources.exit;
            this.picExit.Location = new System.Drawing.Point(745, -1);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(94, 89);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 588);
            this.Controls.Add(this.TextShowTitle);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.panelDecrypy);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelEncryptions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelEncryptions.ResumeLayout(false);
            this.panelEncryptions.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowImg)).EndInit();
            this.panelDecrypy.ResumeLayout(false);
            this.panelDecrypy.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShowDec)).EndInit();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.LoadIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelEncryptions;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbStatusBro;
        private System.Windows.Forms.Button btnBrowsee;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.PictureBox pictureShowImg;
        private System.Windows.Forms.TextBox tbEncShow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDecrypy;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbStatusBroDec;
        private System.Windows.Forms.Button btnDec;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox picShowDec;
        private System.Windows.Forms.TextBox tbDec;
        private System.Windows.Forms.Label TextShowTitle;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LoadIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

