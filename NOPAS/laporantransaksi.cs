﻿using System;
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
            string query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.days, t.nomor_unik, " +
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
            if (tglakhir.Value.Date < tglawal.Value.Date)
            {
                MessageBox.Show("Tanggal yang dimasukan tidak benar");
            }
            else
            {
                if (cari.Text == string.Empty)
                {
                    SearchTanggal();
                }
                else
                {
                    Search();
                }
            }
        }
        void SearchTanggal()
        {
            try
            {
                // Inisialisasi koneksi di luar blok using
                koneksi.Open();

                string query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.days, t.nomor_unik, " +
                               "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                               "FROM transactions t " +
                               "JOIN products p ON t.id_produk = p.id " +
                               "WHERE t.created_at BETWEEN @startDate AND @endDate";
                MySqlCommand command = new MySqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@startDate", tglawal.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@endDate", tglakhir.Value.AddDays(1).ToString("yyyy-MM-dd"));
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridTransaksi.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tutup koneksi di blok finally untuk memastikan koneksi ditutup setelah digunakan
                koneksi.Close();
            }
        }
        void Search(bool filterTanggal = false)
        {
            try
            {
                koneksi.Open();

                string query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.days, t.nomor_unik, " +
                               "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                               "FROM transactions t " +
                               "JOIN products p ON t.id_produk = p.id ";

                if (filterTanggal)
                {
                    query += "WHERE t.created_at BETWEEN @startDate AND @endDate AND p.nama_produk LIKE @namaProduk";
                }
                else
                {
                    query += "WHERE p.nama_produk LIKE @namaProduk";
                }

                MySqlCommand command = new MySqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@namaProduk", "%" + cari.Text + "%");

                if (filterTanggal)
                {
                    command.Parameters.AddWithValue("@startDate", tglawal.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@endDate", tglakhir.Value.AddDays(1).ToString("yyyy-MM-dd"));
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridTransaksi.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.Close();
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

                // Membuat table dengan jumlah kolom sesuai dengan jumlah kolom di dalam DataGridView
                PdfPTable table = new PdfPTable(8);
                string[] headers = { "ID", "Nama Produk", "Nomor Unik", "Nama Pelanggan", "Qty", "Day", "Total", "Tanggal" };
                foreach (string header in headers)

                    // Menambahkan header ke dalam table
                    //for (int i = 0; i < dataGridTransaksi.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Padding = 5;
                    cell.BorderWidth = 1;
                    table.AddCell(cell);
                }

                // Menambahkan data dari DataGridView ke dalam table
                foreach (DataGridViewRow row in dataGridTransaksi.Rows)
                {
                        if (!row.IsNewRow)
                        {
                        PdfPCell cell1 = new PdfPCell(new Phrase(row.Cells[0].Value?.ToString()));
                        cell1.HorizontalAlignment = Element.ALIGN_CENTER; 
                        table.AddCell(cell1); // ID

                        PdfPCell cell2 = new PdfPCell(new Phrase(row.Cells[1].Value?.ToString()));
                        cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell2); // Nama Produk

                        PdfPCell cell3 = new PdfPCell(new Phrase(row.Cells[6].Value?.ToString()));
                        cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell3); // Nomor Unik

                        PdfPCell cell4 = new PdfPCell(new Phrase(row.Cells[3].Value?.ToString()));
                        cell4.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell4); // Nama Pelanggan

                        PdfPCell cell5 = new PdfPCell(new Phrase(row.Cells[4].Value?.ToString()));
                        cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell5); // Qty

                        PdfPCell cell6 = new PdfPCell(new Phrase(row.Cells[5].Value?.ToString()));
                        cell6.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell6); // Day

                        PdfPCell cell7 = new PdfPCell(new Phrase(row.Cells[9].Value?.ToString()));
                        cell7.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell7); // Total

                        PdfPCell cell8 = new PdfPCell(new Phrase(row.Cells[10].Value?.ToString()));
                        cell7.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell8); // tanggal
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

                // Menutup dokumen dan writer
                doc.Close();
                MessageBox.Show("Data berhasil di-print ke dalam file PDF.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka file PDF setelah disimpan
                Process.Start(saveFileDialog1.FileName);

                LoadAllData();
                
            }
        }
        private bool filterTanggalDipilih()
        {
            return tglawal.Value.Date != DateTime.Today || tglakhir.Value.Date != DateTime.Today;
        }
        private void LoadAllData()
        {
            try
            {
                // Anda bisa memuat data dari sumber data aslinya, dalam kasus ini menggunakan method showData
                l.showData("SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.days, t.nomor_unik, " +
                      "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                      "FROM transactions t " +
                      "JOIN products p ON t.id_produk = p.id", dataGridTransaksi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void reset_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
