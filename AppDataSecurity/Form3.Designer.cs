
namespace AppDataSecurity
{
    partial class Form3
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbForm3Change = new System.Windows.Forms.Label();
            this.tbPassCon = new System.Windows.Forms.TextBox();
            this.BtnForm3Change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFrom3Decrypt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            this.bunifuElipse2.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 314);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.tbPass);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tbPassCon);
            this.panel2.Controls.Add(this.BtnForm3Change);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnFrom3Decrypt);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 227);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(134, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(134, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 1);
            this.panel6.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("ONE DAY", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPass.ForeColor = System.Drawing.Color.Lime;
            this.tbPass.Location = new System.Drawing.Point(143, 138);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(144, 11);
            this.tbPass.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbForm3Change);
            this.panel4.ForeColor = System.Drawing.Color.Coral;
            this.panel4.Location = new System.Drawing.Point(32, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 30);
            this.panel4.TabIndex = 2;
            // 
            // lbForm3Change
            // 
            this.lbForm3Change.AutoSize = true;
            this.lbForm3Change.Font = new System.Drawing.Font("ONE DAY", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbForm3Change.ForeColor = System.Drawing.Color.Coral;
            this.lbForm3Change.Location = new System.Drawing.Point(6, 10);
            this.lbForm3Change.Name = "lbForm3Change";
            this.lbForm3Change.Size = new System.Drawing.Size(38, 13);
            this.lbForm3Change.TabIndex = 0;
            this.lbForm3Change.Text = "label1";
            //
            // tbPassCon
            // 
            this.tbPassCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.tbPassCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassCon.Font = new System.Drawing.Font("ONE DAY", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPassCon.ForeColor = System.Drawing.Color.Lime;
            this.tbPassCon.Location = new System.Drawing.Point(144, 168);
            this.tbPassCon.Name = "tbPassCon";
            this.tbPassCon.PasswordChar = '*';
            this.tbPassCon.Size = new System.Drawing.Size(144, 11);
            this.tbPassCon.TabIndex = 7;
            // 
            // BtnForm3Change
            // 
            this.BtnForm3Change.FlatAppearance.BorderSize = 0;
            this.BtnForm3Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForm3Change.Font = new System.Drawing.Font("Orator Std", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BtnForm3Change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnForm3Change.Location = new System.Drawing.Point(316, 73);
            this.BtnForm3Change.Name = "BtnForm3Change";
            this.BtnForm3Change.Size = new System.Drawing.Size(100, 42);
            this.BtnForm3Change.TabIndex = 3;
            this.BtnForm3Change.Text = "Change";
            this.BtnForm3Change.UseVisualStyleBackColor = true;
            this.BtnForm3Change.Click += new System.EventHandler(this.BtnForm3Change_Click);
            this.BtnForm3Change.MouseLeave += new System.EventHandler(this.BtnForm3Change_MouseLeave);
            this.BtnForm3Change.MouseHover += new System.EventHandler(this.BtnForm3Change_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ONE DAY", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm  Password";
            // 
            // btnFrom3Decrypt
            // 
            this.btnFrom3Decrypt.FlatAppearance.BorderSize = 0;
            this.btnFrom3Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrom3Decrypt.Font = new System.Drawing.Font("Orator Std", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFrom3Decrypt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFrom3Decrypt.Location = new System.Drawing.Point(316, 143);
            this.btnFrom3Decrypt.Name = "btnFrom3Decrypt";
            this.btnFrom3Decrypt.Size = new System.Drawing.Size(100, 52);
            this.btnFrom3Decrypt.TabIndex = 4;
            this.btnFrom3Decrypt.Text = "Decrypt";
            this.btnFrom3Decrypt.UseVisualStyleBackColor = true;
            this.btnFrom3Decrypt.Click += new System.EventHandler(this.btnFrom3Decrypt_Click);
            this.btnFrom3Decrypt.MouseLeave += new System.EventHandler(this.btnFrom3Decrypt_MouseLeave);
            this.btnFrom3Decrypt.MouseHover += new System.EventHandler(this.btnFrom3Decrypt_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(34, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 1);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ONE DAY", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Password";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.BackgroundImage = global::AppDataSecurity.Properties.Resources._154328700_487868112216826_2203631973212494915_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(503, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbForm3Change;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFrom3Decrypt;
        private System.Windows.Forms.Button BtnForm3Change;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPassCon;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}