using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace NOPAS
{
    public partial class laporantransaksi : Form
    {
        Data l = new Data();
        DateTime tgl1;
        string tglS1;
        DateTime tgl2;
        string tglS2;
        public laporantransaksi()
        {
            InitializeComponent();
            tglawal.CustomFormat = "dd/MM/yyyy";
            tglakhir.CustomFormat = "dd/MM/yyyy";

            cetak.Click += new EventHandler(cetak_Click);
        }
        Data func = new Data();
        public static string con = "Server=localhost;Database=nopas;user=root;Pwd= ;SslMode=none";
        MySqlConnection koneksi = new MySqlConnection(con);

        private void datatransaksi_Load(object sender, EventArgs e)
        {
            string query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                           "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                           "FROM transactions t " +
                           "JOIN products p ON t.id_produk = p.id " +
                           "ORDER BY t.created_at ASC";

            l.showData(query, dataGridTransaksi);
            lbnama.Text = "hi, " + Data.nama + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Berandaowner().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogAktivity().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=nopas"))
                {
                    conn.Open();
                    using (DataTable dt = new DataTable("transactions"))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                                                                   "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                                                                   "FROM transactions t " +
                                                                   "JOIN products p ON t.id_produk = p.id " +
                                                                   "WHERE DATE(t.created_at) BETWEEN DATE(@fromdate) AND DATE(@todate) " +
                                                                   "ORDER BY t.created_at ASC", conn))
                        {
                            cmd.Parameters.AddWithValue("@fromdate", tglawal.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@todate", tglakhir.Value.ToString("yyyy-MM-dd"));

                            using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd))
                            {
                                mySqlDataAdapter.Fill(dt);
                                dataGridTransaksi.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nampro_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string Harga()
        {
            int total = 0;

            for (int i = 0; i < dataGridTransaksi.Rows.Count; ++i)
            {
                string nilaiSel = dataGridTransaksi.Rows[i].Cells[9].Value?.ToString(); // Mengambil nilai sel sebagai string

                if (int.TryParse(nilaiSel, out int hargaBaris))
                {
                    total += hargaBaris;
                }
                else
                {
                    // Penanganan jika nilai tidak dapat diubah menjadi bilangan bulat
                    Console.WriteLine($"Nilai pada baris {i} tidak dapat diubah menjadi bilangan bulat: {nilaiSel}");
                }
            }

            return total.ToString();
        }

        private void cetak_Click(object sender, EventArgs e)
        {
            // Membuat instance dari class Document iTextSharp
            Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);

            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);


            // Membuat objek paragraph dengan judul
            Paragraph title = new Paragraph("Laporan Transaksi", fontTitle);
            title.Alignment = Element.ALIGN_CENTER; // Mengatur perataan teks
            title.SpacingAfter = 40;
            title.SpacingBefore = 40;

            // Membuat objek Paragraph untuk menampung kalimat di bagian bawah tabel
            Paragraph p = new Paragraph("Total Pemasukan : Rp. " + Harga(), font);
            p.SpacingBefore = 30;

            // Menentukan lokasi penyimpanan file PDF
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF (.pdf)|.pdf";
            saveFileDialog1.FileName = "Data.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Membuka file PDF
                PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));

                // Membuka dokumen
                doc.Open();

                string query;

                if (filterTanggalDipilih() && !string.IsNullOrWhiteSpace(nampro.Text))
                {
                    // Jika ya, gunakan rentang tanggal dan nama produk yang dipilih
                    DateTime startDate = tglawal.Value.Date;
                    DateTime endDate = tglakhir.Value.Date.AddDays(1); // Tambah 1 hari agar mencakup seluruh tanggal di hari terakhir
                    string formattedStartDate = startDate.ToString("yyyy-MM-dd");
                    string formattedEndDate = endDate.ToString("yyyy-MM-dd");
                    string namaProdukFilter = nampro.Text.Trim();

                    query = $"SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                            $"t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                            $"FROM transactions t " +
                            $"JOIN products p ON t.id_produk = p.id " +
                            $"WHERE t.created_at >= '{formattedStartDate}' AND t.created_at < '{formattedEndDate}' AND p.nama_produk LIKE '%{namaProdukFilter}%' " +
                            $"ORDER BY t.created_at ASC";
                }
                else if (filterTanggalDipilih())
                {
                    // Jika hanya filter tanggal yang dipilih
                    DateTime startDate = tglawal.Value.Date;
                    DateTime endDate = tglakhir.Value.Date.AddDays(1); // Tambah 1 hari agar mencakup seluruh tanggal di hari terakhir
                    string formattedStartDate = startDate.ToString("yyyy-MM-dd");
                    string formattedEndDate = endDate.ToString("yyyy-MM-dd");

                    query = $"SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                            $"t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                            $"FROM transactions t " +
                            $"JOIN products p ON t.id_produk = p.id " +
                            $"WHERE t.created_at >= '{formattedStartDate}' AND t.created_at < '{formattedEndDate}' " +
                            $"ORDER BY t.created_at ASC";
                }
                else if (!string.IsNullOrWhiteSpace(nampro.Text))
                {
                    // Jika hanya nama produk yang dipilih
                    string namaProdukFilter = nampro.Text.Trim();

                    query = $"SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                            $"t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                            $"FROM transactions t " +
                            $"JOIN products p ON t.id_produk = p.id " +
                            $"WHERE p.nama_produk LIKE '%{namaProdukFilter}%' " +
                            $"ORDER BY t.created_at ASC";
                }
                else
                {
                    // Jika tidak ada filter tanggal atau nama produk
                    query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                            "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                            "FROM transactions t " +
                            "JOIN products p ON t.id_produk = p.id " +
                            "ORDER BY t.created_at ASC";
                }


                l.showData(query, dataGridTransaksi); 

                // Membuat table dengan jumlah kolom sesuai dengan jumlah kolom di dalam DataGridView
                PdfPTable table = new PdfPTable(dataGridTransaksi.Columns.Count);

                // Menambahkan header ke dalam table
                for (int i = 0; i < dataGridTransaksi.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridTransaksi.Columns[i].HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Padding = 5;
                    cell.BorderWidth = 1;
                    table.AddCell(cell);
                }

                // Menambahkan data dari DataGridView ke dalam table
                for (int i = 0; i < dataGridTransaksi.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridTransaksi.Columns.Count; j++)
                    {
                        if (dataGridTransaksi[j, i].Value != null)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dataGridTransaksi[j, i].Value.ToString()));
                            cell.Padding = 5;
                            cell.BorderWidth = 1;
                            table.AddCell(cell);
                        }
                    }
                }

                // Mengatur garis di sekitar tabel
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.BorderColor = new iTextSharp.text.BaseColor(200, 200, 200);
                table.DefaultCell.Padding = 7;
                table.WidthPercentage = 100;

                // Menambahkan paragraph ke dokumen
                doc.Add(title);

                // Menambahkan table ke dalam dokumen
                doc.Add(table);

                // Menambahkan kalimat ke dokumen
                doc.Add(p);

                // Menutup dokumen dan writer
                doc.Close();
                MessageBox.Show("Data berhasil di-print ke dalam file PDF.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka file PDF setelah disimpan
                Process.Start(saveFileDialog1.FileName);
            }
        }
        private bool filterTanggalDipilih()
        {
            return tglawal.Value.Date != DateTime.Today || tglakhir.Value.Date != DateTime.Today;
        }

        private void tgl1_ValueChanged(object sender, EventArgs e)
        {
            tgl1 = tglawal.Value;
            tglS1 = tgl1.ToString("yyyy-MM-dd");
        }

        private void tglakhir_ValueChanged(object sender, EventArgs e)
        {
            tgl2 = tglakhir.Value;
            tglS2 = tgl2.ToString("yyyy-MM-dd");
        }
    }
}
