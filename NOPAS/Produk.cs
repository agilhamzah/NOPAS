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
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NOPAS
{
    public partial class Produk : Form
    {
        string id;
        public Produk()
        {
            InitializeComponent();
        }
        Data p = new Data();
        bool isEditMode = false;
        void clear()
        {
            id = string.Empty;
            namproduk.Text = string.Empty;
            harproduk.Text = string.Empty;
            stok.Text = string.Empty;
            day.Text = string.Empty;
            p.showData("Select * from products", dataGridView1);
        }
        private void Produk_Load(object sender, EventArgs e)
        {

            clear();

            lbnama.Text = "hi, " + Data.nama + "!";
        }


        private void edit_Click(object sender, EventArgs e)
        {
            clear();
            isEditMode = false;
            tambah.Text = "Tambah";
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                DialogResult editResult = MessageBox.Show("Anda yakin ingin mengedit produk?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (editResult == DialogResult.Yes)
                {
                    p.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Admin Mengubah produk', NOW())");
                    MessageBox.Show("Anda telah mengubah produk", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (namproduk.Text == string.Empty || harproduk.Text == string.Empty || stok.Text == string.Empty || day.Text == string.Empty)
                    {
                        MessageBox.Show("Semua kolom harus di isi!");
                    }
                    else
                    {
                        p.command("update products set nama_produk = '" + namproduk.Text + "', harga_produk = '" + harproduk.Text + "', stok = '" + stok.Text + "', days = '" + day.Text + "', updated_at = NOW() where id = '" + id + "' ");
                        clear();
                        isEditMode = false;
                        tambah.Text = "Tambah";
                    }
                }
                else
                {
                    // Jika tidak jadi mengedit, kembali ke mode tambah
                    isEditMode = false;
                    tambah.Text = "Tambah";
                    clear(); // Menghapus isian
                }
            }
            else
            {
                // Logika mode tambah
                DialogResult result = MessageBox.Show("Anda yakin ingin menambah produk?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    clear();
                }

                if (result == DialogResult.Yes)
                {
                    p.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Admin Menambahkan produk', NOW())");
                    MessageBox.Show("Anda telah menambahkan produk", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (namproduk.Text == string.Empty || harproduk.Text == string.Empty || stok.Text == string.Empty || day.Text == string.Empty)
                    {
                        MessageBox.Show("Semua kolom harus di isi!");
                    }
                    else
                    {
                        string query = "INSERT INTO products ( nama_produk, harga_produk, stok, days, created_at) VALUES ( '" + namproduk.Text + "', '" + harproduk.Text + "', '" + stok.Text + "', '" + day.Text + "', NOW() )";
                        p.command(query);
                        clear();
                    }
                }
                else
                {
                    clear();
                }
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            {
                p.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Admin Mengahapus user', NOW())");
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    p.command("delete from products where nama_produk = '" + namproduk.Text + "' ");
                    MessageBox.Show("Produk berhasil di hapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    p.command("insert into log (id_user, activity, created_at) VALUES('" + Data.id_user + "', 'Admin menghapus produk', NOW())");
                    clear();

                    isEditMode = false;
                    tambah.Text = "Tambah";
                }

            }
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            this.Close();
            new Berandaadmin().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];

            namproduk.Text = dr.Cells[1].Value.ToString();
            harproduk.Text = dr.Cells[2].Value.ToString();
            stok.Text = dr.Cells[3].Value.ToString();
            day.Text = dr.Cells[4].Value.ToString();

            id = dr.Cells[0].Value.ToString();
            isEditMode = true;
            tambah.Text = "Edit";
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM products WHERE nama_produk LIKE '%" + cari.Text + "%'";
            p.showData(query, dataGridView1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat instance dari class Document iTextSharp
            Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);

            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);


            // Membuat objek paragraph dengan judul
            Paragraph title = new Paragraph("Laporan Produk", fontTitle);
            title.Alignment = Element.ALIGN_CENTER; // Mengatur perataan teks
            title.SpacingAfter = 40;
            title.SpacingBefore = 40;

            // Membuat objek Paragraph untuk menampung kalimat di bagian bawah tabel



            // Menentukan lokasi penyimpanan file PDF
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF (.pdf)|.pdf";
            saveFileDialog1.FileName = "Data Produk.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Membuka file PDF
                PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));

                // Membuka dokumen
                doc.Open();

                // Membuat table dengan jumlah kolom sesuai dengan jumlah kolom di dalam DataGridView
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                // Menambahkan header ke dalam table
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Padding = 5;
                    cell.BorderWidth = 1;
                    table.AddCell(cell);
                }

                // Menambahkan data dari DataGridView ke dalam table
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dataGridView1[j, i].Value.ToString()));
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

                // Menutup dokumen dan writer
                doc.Close();
                MessageBox.Show("Data berhasil di-print ke dalam file PDF.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka file PDF setelah disimpan
                Process.Start(saveFileDialog1.FileName);
            }
        }
    }
}
