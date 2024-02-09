namespace NOPAS
{
    partial class LogAktivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAktivity));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.datefilter2 = new System.Windows.Forms.DateTimePicker();
            this.dglogakt = new System.Windows.Forms.DataGridView();
            this.filterlog = new System.Windows.Forms.Button();
            this.datefilter1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgproduk = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.caritxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglogakt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgproduk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbnama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 482);
            this.panel1.TabIndex = 4;
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
            this.button1.Location = new System.Drawing.Point(71, 410);
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
            this.pictureBox1.Location = new System.Drawing.Point(71, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.caritxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgproduk);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbrole);
            this.panel2.Controls.Add(this.datefilter2);
            this.panel2.Controls.Add(this.dglogakt);
            this.panel2.Controls.Add(this.filterlog);
            this.panel2.Controls.Add(this.datefilter1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(399, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 648);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(597, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Role";
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "admin",
            "kasir"});
            this.cbrole.Location = new System.Drawing.Point(660, 125);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(121, 28);
            this.cbrole.TabIndex = 8;
            // 
            // datefilter2
            // 
            this.datefilter2.Location = new System.Drawing.Point(312, 123);
            this.datefilter2.Name = "datefilter2";
            this.datefilter2.Size = new System.Drawing.Size(259, 26);
            this.datefilter2.TabIndex = 7;
            this.datefilter2.Value = new System.DateTime(2024, 1, 14, 19, 54, 25, 0);
            // 
            // dglogakt
            // 
            this.dglogakt.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dglogakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglogakt.Location = new System.Drawing.Point(37, 199);
            this.dglogakt.Name = "dglogakt";
            this.dglogakt.RowHeadersWidth = 62;
            this.dglogakt.RowTemplate.Height = 28;
            this.dglogakt.Size = new System.Drawing.Size(795, 171);
            this.dglogakt.TabIndex = 6;
            this.dglogakt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dglogakt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filterlog
            // 
            this.filterlog.BackColor = System.Drawing.Color.Maroon;
            this.filterlog.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterlog.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filterlog.Location = new System.Drawing.Point(37, 159);
            this.filterlog.Name = "filterlog";
            this.filterlog.Size = new System.Drawing.Size(116, 34);
            this.filterlog.TabIndex = 3;
            this.filterlog.Text = "Filter";
            this.filterlog.UseVisualStyleBackColor = false;
            this.filterlog.Click += new System.EventHandler(this.button4_Click);
            // 
            // datefilter1
            // 
            this.datefilter1.Location = new System.Drawing.Point(37, 123);
            this.datefilter1.Name = "datefilter1";
            this.datefilter1.Size = new System.Drawing.Size(259, 26);
            this.datefilter1.TabIndex = 5;
            this.datefilter1.Value = new System.DateTime(2024, 1, 14, 19, 54, 25, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(32, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pilih Tanggal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Log Aktivitas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Produk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgproduk
            // 
            this.dgproduk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproduk.Location = new System.Drawing.Point(37, 447);
            this.dgproduk.Name = "dgproduk";
            this.dgproduk.RowHeadersWidth = 62;
            this.dgproduk.RowTemplate.Height = 28;
            this.dgproduk.Size = new System.Drawing.Size(795, 189);
            this.dgproduk.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(567, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cari";
            // 
            // caritxt
            // 
            this.caritxt.Location = new System.Drawing.Point(625, 410);
            this.caritxt.Name = "caritxt";
            this.caritxt.Size = new System.Drawing.Size(207, 26);
            this.caritxt.TabIndex = 13;
            // 
            // LogAktivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1304, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogAktivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Log Aktivitas";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglogakt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgproduk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datefilter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dglogakt;
        private System.Windows.Forms.Button filterlog;
        private System.Windows.Forms.DateTimePicker datefilter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgproduk;
        private System.Windows.Forms.TextBox caritxt;
    }
}