namespace NOPAS
{
    partial class historitransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historitransaksi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dghistori = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghistori)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbnama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 514);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(77, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lbnama.Location = new System.Drawing.Point(29, 311);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(141, 31);
            this.lbnama.TabIndex = 0;
            this.lbnama.Text = "Hi, Lembus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "KASIR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 103);
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
            this.panel2.Controls.Add(this.cetak);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cari);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dghistori);
            this.panel2.Location = new System.Drawing.Point(407, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 648);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cetak
            // 
            this.cetak.BackColor = System.Drawing.Color.Maroon;
            this.cetak.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cetak.Location = new System.Drawing.Point(336, 94);
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(124, 45);
            this.cetak.TabIndex = 2;
            this.cetak.Text = "cetak";
            this.cetak.UseVisualStyleBackColor = false;
            this.cetak.Click += new System.EventHandler(this.cetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cari";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cari
            // 
            this.cari.Location = new System.Drawing.Point(95, 103);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(225, 26);
            this.cari.TabIndex = 5;
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Histori Transaksi";
            // 
            // dghistori
            // 
            this.dghistori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dghistori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghistori.Location = new System.Drawing.Point(46, 155);
            this.dghistori.Name = "dghistori";
            this.dghistori.RowHeadersWidth = 62;
            this.dghistori.RowTemplate.Height = 28;
            this.dghistori.Size = new System.Drawing.Size(778, 447);
            this.dghistori.TabIndex = 3;
            this.dghistori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dghistori_CellClick);
            this.dghistori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // historitransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1304, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "historitransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Histori Transaksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghistori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dghistori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.Button cetak;
    }
}