namespace NOPAS
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomorunik = new System.Windows.Forms.TextBox();
            this.nampel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbday = new System.Windows.Forms.ComboBox();
            this.datastok = new System.Windows.Forms.DataGridView();
            this.uangkembali = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.batal = new System.Windows.Forms.Button();
            this.btnpesan = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.uangbyr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.quantitas = new System.Windows.Forms.TextBox();
            this.harsat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cblkbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keluar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.datastok);
            this.panel2.Controls.Add(this.uangkembali);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.total);
            this.panel2.Controls.Add(this.batal);
            this.panel2.Controls.Add(this.btnpesan);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.uangbyr);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.quantitas);
            this.panel2.Controls.Add(this.harsat);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cblkbb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(397, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 648);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.nomorunik);
            this.panel3.Controls.Add(this.nampel);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbday);
            this.panel3.Location = new System.Drawing.Point(41, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 271);
            this.panel3.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(27, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 27);
            this.label16.TabIndex = 24;
            this.label16.Text = "Nomor Unik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nama Pelanggan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nomorunik
            // 
            this.nomorunik.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorunik.Location = new System.Drawing.Point(32, 135);
            this.nomorunik.Name = "nomorunik";
            this.nomorunik.Size = new System.Drawing.Size(237, 34);
            this.nomorunik.TabIndex = 7;
            this.nomorunik.TextChanged += new System.EventHandler(this.nounik_TextChanged);
            // 
            // nampel
            // 
            this.nampel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nampel.Location = new System.Drawing.Point(32, 217);
            this.nampel.Name = "nampel";
            this.nampel.Size = new System.Drawing.Size(237, 34);
            this.nampel.TabIndex = 11;
            this.nampel.TextChanged += new System.EventHandler(this.nampel_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 27);
            this.label11.TabIndex = 16;
            this.label11.Text = "Day";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbday
            // 
            this.cbday.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbday.FormattingEnabled = true;
            this.cbday.Location = new System.Drawing.Point(32, 49);
            this.cbday.Name = "cbday";
            this.cbday.Size = new System.Drawing.Size(237, 35);
            this.cbday.TabIndex = 17;
            this.cbday.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // datastok
            // 
            this.datastok.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datastok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastok.Location = new System.Drawing.Point(392, 389);
            this.datastok.Name = "datastok";
            this.datastok.RowHeadersWidth = 62;
            this.datastok.RowTemplate.Height = 28;
            this.datastok.Size = new System.Drawing.Size(452, 234);
            this.datastok.TabIndex = 28;
            this.datastok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastok_CellClick);
            // 
            // uangkembali
            // 
            this.uangkembali.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uangkembali.Location = new System.Drawing.Point(639, 258);
            this.uangkembali.Name = "uangkembali";
            this.uangkembali.Size = new System.Drawing.Size(203, 34);
            this.uangkembali.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Uang Bayar";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(407, 336);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(202, 34);
            this.total.TabIndex = 25;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // batal
            // 
            this.batal.BackColor = System.Drawing.Color.Maroon;
            this.batal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.batal.Location = new System.Drawing.Point(745, 327);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(102, 38);
            this.batal.TabIndex = 23;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = false;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // btnpesan
            // 
            this.btnpesan.BackColor = System.Drawing.Color.Maroon;
            this.btnpesan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnpesan.Location = new System.Drawing.Point(637, 327);
            this.btnpesan.Name = "btnpesan";
            this.btnpesan.Size = new System.Drawing.Size(102, 38);
            this.btnpesan.TabIndex = 1;
            this.btnpesan.Text = "Pesan";
            this.btnpesan.UseVisualStyleBackColor = false;
            this.btnpesan.Click += new System.EventHandler(this.btnpesan_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(634, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 27);
            this.label15.TabIndex = 21;
            this.label15.Text = "Kembalian";
            // 
            // uangbyr
            // 
            this.uangbyr.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uangbyr.Location = new System.Drawing.Point(640, 183);
            this.uangbyr.Name = "uangbyr";
            this.uangbyr.Size = new System.Drawing.Size(200, 34);
            this.uangbyr.TabIndex = 20;
            this.uangbyr.TextChanged += new System.EventHandler(this.uangbyr_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(402, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 27);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Harga";
            // 
            // quantitas
            // 
            this.quantitas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitas.Location = new System.Drawing.Point(407, 257);
            this.quantitas.Name = "quantitas";
            this.quantitas.Size = new System.Drawing.Size(203, 34);
            this.quantitas.TabIndex = 15;
            this.quantitas.TextChanged += new System.EventHandler(this.quantitas_TextChanged);
            // 
            // harsat
            // 
            this.harsat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harsat.Location = new System.Drawing.Point(406, 182);
            this.harsat.Name = "harsat";
            this.harsat.Size = new System.Drawing.Size(203, 34);
            this.harsat.TabIndex = 13;
            this.harsat.TextChanged += new System.EventHandler(this.harsat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quantitas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Harga Satuan";
            // 
            // cblkbb
            // 
            this.cblkbb.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblkbb.FormattingEnabled = true;
            this.cblkbb.Location = new System.Drawing.Point(41, 153);
            this.cblkbb.Name = "cblkbb";
            this.cblkbb.Size = new System.Drawing.Size(329, 33);
            this.cblkbb.TabIndex = 5;
            this.cblkbb.SelectedIndexChanged += new System.EventHandler(this.cblkbb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama LKBB";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Halaman Transaksi";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbnama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.keluar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 482);
            this.panel1.TabIndex = 0;
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lbnama.Location = new System.Drawing.Point(29, 302);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(141, 31);
            this.lbnama.TabIndex = 0;
            this.lbnama.Text = "Hi, Lembus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "KASIR";
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.Maroon;
            this.keluar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.keluar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.keluar.Location = new System.Drawing.Point(75, 413);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(205, 55);
            this.keluar.TabIndex = 0;
            this.keluar.Text = "Kembali";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1304, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Transaksi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button btnpesan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox uangbyr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox quantitas;
        private System.Windows.Forms.TextBox harsat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nampel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomorunik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cblkbb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.TextBox uangkembali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datastok;
        private System.Windows.Forms.Panel panel3;
    }
}