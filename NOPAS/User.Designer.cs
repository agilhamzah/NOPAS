﻿namespace NOPAS
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.lbnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hapus = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.namleng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.lbnama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 514);
            this.panel1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(77, 435);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 55);
            this.button6.TabIndex = 3;
            this.button6.Text = "kembali";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnama.Location = new System.Drawing.Point(36, 284);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(141, 31);
            this.lbnama.TabIndex = 0;
            this.lbnama.Text = "Hi, Lembus";
            this.lbnama.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cari);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.hapus);
            this.panel2.Controls.Add(this.batal);
            this.panel2.Controls.Add(this.tambah);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.namleng);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pw);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(405, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 648);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.label2.Location = new System.Drawing.Point(543, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cari";
            // 
            // cari
            // 
            this.cari.Location = new System.Drawing.Point(589, 302);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(253, 26);
            this.cari.TabIndex = 17;
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 280);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.Maroon;
            this.hapus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hapus.Location = new System.Drawing.Point(281, 254);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(121, 47);
            this.hapus.TabIndex = 15;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // batal
            // 
            this.batal.BackColor = System.Drawing.Color.Maroon;
            this.batal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.batal.Location = new System.Drawing.Point(167, 254);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(108, 47);
            this.batal.TabIndex = 14;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = false;
            this.batal.Click += new System.EventHandler(this.edit_Click);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.Maroon;
            this.tambah.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tambah.Location = new System.Drawing.Point(35, 254);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(126, 47);
            this.tambah.TabIndex = 13;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "admin",
            "kasir",
            "owner"});
            this.role.Location = new System.Drawing.Point(484, 199);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(242, 28);
            this.role.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.label7.Location = new System.Drawing.Point(479, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Role";
            // 
            // namleng
            // 
            this.namleng.Location = new System.Drawing.Point(484, 123);
            this.namleng.Name = "namleng";
            this.namleng.Size = new System.Drawing.Size(242, 26);
            this.namleng.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.label6.Location = new System.Drawing.Point(479, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nama Lengkap";
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(108, 199);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(253, 26);
            this.pw.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.label5.Location = new System.Drawing.Point(108, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(108, 117);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(253, 26);
            this.username.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.label4.Location = new System.Drawing.Point(103, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tambah User";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1304, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman User";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox namleng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.Label label2;
    }
}