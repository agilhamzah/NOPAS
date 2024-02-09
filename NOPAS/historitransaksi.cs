using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NOPAS
{
    public partial class historitransaksi : Form
    {
        string id;

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=nopas");
        Data h = new Data();
        public historitransaksi()
        {
            InitializeComponent();
        }

        void clear()
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Berandakasir().Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                            "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                            "FROM transactions t " +
                            "JOIN products p ON t.id_produk = p.id " +
                            "ORDER BY t.created_at ASC";

            h.showData(query, dghistori);
            lbnama.Text = "hi, " + Data.nama + "!";
           
        }
        private void LoadTransactionHistory()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection ("server=127.0.0.1;port=3306;username=root;password=;database=nopas"))
                {
                    connection.Open();

                    string query = "SELECT id_produk, nama_pelanggan, qty, vote_pasukan, nomor_unik, uang_bayar, uang_kembali, total_harga, created_at FROM transactions";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dghistori.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            string keyword = cari.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                string query = "SELECT t.id, p.nama_produk, p.harga_produk, t.nama_pelanggan, t.qty, t.vote_pasukan, t.nomor_unik, " +
                               "t.uang_bayar, t.uang_kembali, t.total_harga, t.created_at " +
                               "FROM transactions t " +
                               "JOIN products p ON t.id_produk = p.id " +
                               $"WHERE p.nama_produk LIKE '%{keyword}%' " +
                               "ORDER BY t.created_at ASC";

                h.showData(query, dghistori);
            }
            else
            {
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private DataGridViewRow selectedRow;
        private void setDataToStruk(string namaPelanggan, DataGridViewRow dr, CrystalReport2 cr1)
        {
            // Mengatur tanggal pembelian pada struk
            using (MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=nopas"))
            {
                conn.Open();
                MySqlCommand getDateCommand = new MySqlCommand("SELECT created_at FROM transactions WHERE nama_pelanggan = @namapelanggan", conn);
                getDateCommand.Parameters.AddWithValue("@namapelanggan", namaPelanggan);

                using (MySqlDataReader dateReader = getDateCommand.ExecuteReader())
                {
                    if (dateReader.Read())
                    {
                        DateTime tanggalPembelian = dateReader.GetDateTime(0);
                        TextObject tanggalB = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["tanggalb"];
                        tanggalB.Text = " " + tanggalPembelian.ToString("dd/MM/yyyy");
                    }
                }
            }

            // Mengatur nilai-nilai lainnya pada struk langsung dari DataGridViewRow
            TextObject namapel = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["nampel"];
            namapel.Text = namaPelanggan;

            TextObject nounik = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["nounik"];
            nounik.Text = dr.Cells["nomor_unik"].Value.ToString();
            TextObject namapro = (TextObject)cr1.ReportDefinition.Sections["Section3"].ReportObjects["nampro"];
            namapro.Text = dr.Cells["nama_produk"].Value.ToString();
            TextObject harga = (TextObject)cr1.ReportDefinition.Sections["Section3"].ReportObjects["harga"];
            harga.Text = dr.Cells["harga_produk"].Value.ToString();
            TextObject Qty = (TextObject)cr1.ReportDefinition.Sections["Section3"].ReportObjects["jumlah"];
            Qty.Text = dr.Cells["qty"].Value.ToString();
            TextObject totalh = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["totalh"];
            totalh.Text = dr.Cells["total_harga"].Value.ToString();
            TextObject uangb = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["uangb"];
            uangb.Text = dr.Cells["uang_bayar"].Value.ToString();
            TextObject kembali = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["kembali"];
            kembali.Text = dr.Cells["uang_kembali"].Value.ToString();
        }


        private void dghistori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Simpan baris yang dipilih saat sel di DataGridView diklik
                if (e.RowIndex >= 0)
                {
                    selectedRow = dghistori.Rows[e.RowIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cetak_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow != null)
                {
                    string namaPelanggan = selectedRow.Cells["nama_pelanggan"].Value.ToString();

                    laporan frm = new laporan();
                    CrystalReport2 cr1 = new CrystalReport2();

                    setDataToStruk(namaPelanggan, selectedRow, cr1);

                    frm.crystalReportViewer1.ReportSource = cr1;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Pilih data terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void hapus_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
