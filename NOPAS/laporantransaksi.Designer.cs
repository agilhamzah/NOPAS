namespace NOPAS
{
    partial class laporantransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laporantransaksi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tglakhir = new System.Windows.Forms.DateTimePicker();
            this.tglawal = new System.Windows.Forms.DateTimePicker();
            this.cetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nampro = new System.Windows.Forms.TextBox();
            this.dataGridTransaksi = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbnama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 482);
            this.panel1.TabIndex = 5;
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lbnama.Location = new System.Drawing.Point(29, 272);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(141, 31);
            this.lbnama.TabIndex = 0;
            this.lbnama.Text = "Hi, Lembus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "OWNER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(71, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tglakhir);
            this.panel2.Controls.Add(this.tglawal);
            this.panel2.Controls.Add(this.cetak);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nampro);
            this.panel2.Controls.Add(this.dataGridTransaksi);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(396, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 648);
            this.panel2.TabIndex = 6;
            // 
            // tglakhir
            // 
            this.tglakhir.Location = new System.Drawing.Point(282, 157);
            this.tglakhir.Name = "tglakhir";
            this.tglakhir.Size = new System.Drawing.Size(234, 26);
            this.tglakhir.TabIndex = 12;
            this.tglakhir.Value = new System.DateTime(2024, 2, 6, 14, 47, 10, 0);
            this.tglakhir.ValueChanged += new System.EventHandler(this.tglakhir_ValueChanged);
            // 
            // tglawal
            // 
            this.tglawal.Location = new System.Drawing.Point(25, 157);
            this.tglawal.Name = "tglawal";
            this.tglawal.Size = new System.Drawing.Size(234, 26);
            this.tglawal.TabIndex = 11;
            this.tglawal.Value = new System.DateTime(2024, 2, 6, 14, 46, 58, 0);
            this.tglawal.ValueChanged += new System.EventHandler(this.tgl1_ValueChanged);
            // 
            // cetak
            // 
            this.cetak.BackColor = System.Drawing.Color.Maroon;
            this.cetak.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cetak.Location = new System.Drawing.Point(22, 202);
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(132, 40);
            this.cetak.TabIndex = 10;
            this.cetak.Text = "Cetak";
            this.cetak.UseVisualStyleBackColor = false;
            this.cetak.Click += new System.EventHandler(this.cetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama LKBB";
            // 
            // nampro
            // 
            this.nampro.Location = new System.Drawing.Point(604, 189);
            this.nampro.Name = "nampro";
            this.nampro.Size = new System.Drawing.Size(245, 26);
            this.nampro.TabIndex = 8;
            this.nampro.TextChanged += new System.EventHandler(this.nampro_TextChanged);
            // 
            // dataGridTransaksi
            // 
            this.dataGridTransaksi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaksi.Location = new System.Drawing.Point(22, 261);
            this.dataGridTransaksi.Name = "dataGridTransaksi";
            this.dataGridTransaksi.RowHeadersWidth = 62;
            this.dataGridTransaksi.RowTemplate.Height = 28;
            this.dataGridTransaksi.Size = new System.Drawing.Size(827, 357);
            this.dataGridTransaksi.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(172, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Filter";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F);
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pilih Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Laporan Transaksi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datatransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1304, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "datatransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Laporan";
            this.Load += new System.EventHandler(this.datatransaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridTransaksi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nampro;
        private System.Windows.Forms.Button cetak;
        private System.Windows.Forms.DateTimePicker tglakhir;
        private System.Windows.Forms.DateTimePicker tglawal;
    }
}