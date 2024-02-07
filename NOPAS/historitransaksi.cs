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
           id = string.Empty;
            cblkbb.Text = string.Empty;
            nomorunik.Text = string.Empty;
            nampel.Text = string.Empty;
            cbpasvaf.Text = string.Empty;
            harsat.Text = string.Empty;
            quantitas.Text = string.Empty;
            total.Text = string.Empty;
            uangbyr.Text = string.Empty;
            uangkembali.Text = string.Empty;
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

        private void dghistori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dghistori.Rows[e.RowIndex];

            cblkbb.Text = dr.Cells[1].Value.ToString();
            nomorunik.Text = dr.Cells[6].Value.ToString();
            nampel.Text = dr.Cells[3].Value.ToString();
            cbpasvaf.Text = dr.Cells[5].Value.ToString();
            harsat.Text = dr.Cells[2].Value.ToString();
            quantitas.Text = dr.Cells[4].Value.ToString();
            total.Text = dr.Cells[9].Value.ToString();
            uangbyr.Text = dr.Cells[7].Value.ToString();
            uangkembali.Text = dr.Cells[8].Value.ToString();

            id = dr.Cells[0].Value.ToString();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cetak_Click(object sender, EventArgs e)
        {
            try
            {
                string namaPelanggan = nampel.Text;
                string namaProduk = cblkbb.Text;
                string votePasukan = cbpasvaf.Text;
                decimal qty = decimal.Parse(quantitas.Text);
                decimal totalHarga = decimal.Parse(total.Text);
                decimal uangBayar = decimal.Parse(uangbyr.Text);
                decimal uangKembali = decimal.Parse(uangkembali.Text);
                decimal hargaSatuan = decimal.Parse(harsat.Text);
               
               
                MessageBox.Show("cetak struk", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                laporan frm = new laporan();
                CrystalReport2 cr1 = new CrystalReport2();
                // Mendapatkan tanggal pembelian dari database
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
                            // Mengatur tanggal pembelian pada struk
                            TextObject tanggalB = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["tanggalb"];
                            tanggalB.Text = " " + tanggalPembelian.ToString("dd/MM/yyyy");
                        }
                    }
                }

                // Mengatur nilai-nilai lainnya pada struk
                TextObject namapel = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["nampel"];
                namapel.Text = nampel.Text;
                TextObject nounik = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["nounik"];
                nounik.Text = nomorunik.Text; // Atur nomor unik sesuai dengan yang dihasilkan sebelumnya
                TextObject namapro = (TextObject)cr1.ReportDefinition.Sections["Section3"].ReportObjects["nampro"];
                namapro.Text = cblkbb.Text;
                TextObject harga = (TextObject)cr1.ReportDefinition.Sections["Section3"].ReportObjects["harga"];
                harga.Text = harsat.Text;
                TextObject Qty = (TextObject)cr1.ReportDefinition.Sections["Section3"].ReportObjects["jumlah"];
                Qty.Text = quantitas.Text;
                TextObject totalh = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["totalh"];
                totalh.Text = total.Text;
                TextObject uangb = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["uangb"];
                uangb.Text = uangbyr.Text;
                TextObject kembali = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["kembali"];
                kembali.Text = uangkembali.Text;

                // Menampilkan form laporan dengan struk yang telah disiapkan
                frm.crystalReportViewer1.ReportSource = cr1;
                frm.Show();

                // Membersihkan nilai-nilai pada form setelah mencetak struk
                clear();
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
    }
}
