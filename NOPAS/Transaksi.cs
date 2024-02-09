using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace NOPAS
{
    public partial class Transaksi : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=nopas");

        Data t = new Data();
        historitransaksi form1 = new historitransaksi();

        void clear()
        {
            cblkbb.Text = string.Empty;
            nomorunik.Text = string.Empty;
            nampel.Text = string.Empty;
            harsat.Text = string.Empty;
            quantitas.Text = string.Empty;
            total.Text = string.Empty;
            uangbyr.Text = string.Empty;
            uangkembali.Text = string.Empty;
            cbpasvaf.Text = string.Empty;

            t.showData("Select * from products", datastok);
            IsiNomorUnikOtomatis();
        }

        public Transaksi()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void UpdateKembalianOtomatis(object sender, EventArgs e)
        {
            if (decimal.TryParse(total.Text, out decimal totalBelanja) && decimal.TryParse(uangbyr.Text, out decimal uangBayar))
            {
                decimal kembalian = HitungKembalian(totalBelanja, uangBayar);

                this.uangkembali.Text = kembalian.ToString("0.##"); 
            }
            else
            {
                uangkembali.Text = "-";
            }
        }

        private decimal HitungKembalian(decimal totalBelanja, decimal uangBayar)
        {
            return uangBayar - totalBelanja;
        }

        private void UpdateTotalBelanjaOtomatis(object sender, EventArgs e)
        {
            if (int.TryParse(quantitas.Text, out int qty) && decimal.TryParse(harsat.Text, out decimal hargasatuan))
            {
                decimal totalBelanja = HitungTotalBelanja(qty, hargasatuan);

                total.Text = totalBelanja.ToString("0.##");
            }
            else
            {
                total.Text = "-";
            }

        }

        private decimal HitungTotalBelanja(int qty,  decimal hargasatuan)
        {
            return qty * hargasatuan;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void FillComboBox()
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=nopas"))
                {
                    conn.Open();

                    if (cbpasvaf.Text != "")
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT jumlah_peserta FROM products WHERE jumlah_peserta = @jumlah_peserta", conn);
                        cmd.Parameters.AddWithValue("@jumlah_peserta", cbpasvaf.Text);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int jumlahPeserta = Convert.ToInt32(reader["jumlah_peserta"]);

                            cbpasvaf.Items.Clear();

                            for (int i = 1; i <= jumlahPeserta; i++)
                            {
                                cbpasvaf.Items.Add(i);
                            }
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            t.GetDataNamaLkbb(cblkbb);
            quantitas.TextChanged += UpdateTotalBelanjaOtomatis;
            harsat.TextChanged += UpdateTotalBelanjaOtomatis;

            total.TextChanged += UpdateKembalianOtomatis;
            uangbyr.TextChanged += UpdateKembalianOtomatis;

            btnpesan.Click -= btnpesan_Click;
            btnpesan.Click += btnpesan_Click;

            lbnama.Text = "hi, " + Data.nama + "!";
            LoadProductData();
            IsiNomorUnikOtomatis();
           
        }
        private void IsiNomorUnikOtomatis()
        {
            // Generate nomor unik secara random
            Random random = new Random();
            int nomorUnik = random.Next(10000, 99999);

            // Set nilai nomor unik ke dalam TextBox
            nomorunik.Text = nomorUnik.ToString();
        }
        private void LoadProductData()
        {
            try
            {
                conn.Open();
                string query = "SELECT id, nama_produk, stok FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                datastok.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Berandakasir().Show();
        }

        private void btnpesan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nampel.Text) || string.IsNullOrWhiteSpace(cblkbb.Text) || string.IsNullOrWhiteSpace(cbpasvaf.Text) ||
                string.IsNullOrWhiteSpace(quantitas.Text) || string.IsNullOrWhiteSpace(total.Text) || string.IsNullOrWhiteSpace(uangbyr.Text) ||
                string.IsNullOrWhiteSpace(uangkembali.Text) || string.IsNullOrWhiteSpace(harsat.Text))
            {
                MessageBox.Show("Harap lengkapi semua kolom sebelum memesan.");
                return;
            }

            string namaPelanggan = nampel.Text;
            string namaProduk = cblkbb.Text;
            string votePasukan = cbpasvaf.Text;
            decimal qty = decimal.Parse(quantitas.Text);
            decimal totalHarga = decimal.Parse(total.Text);
            decimal uangBayar = decimal.Parse(uangbyr.Text);
            decimal uangKembali = decimal.Parse(uangkembali.Text);
            decimal hargaSatuan = decimal.Parse(harsat.Text);
            int nomorUnik;


            Random random = new Random();
            nomorUnik = random.Next(10000, 99999);
            try
            {
                conn.Open();

                MySqlCommand getIdProdukCommand = new MySqlCommand("SELECT id FROM products WHERE nama_produk = @namaProduk", conn);
                getIdProdukCommand.Parameters.AddWithValue("@namaProduk", namaProduk);
                int idProduk;

                using (MySqlDataReader reader = getIdProdukCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idProduk = reader.GetInt32(0);
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan.");
                        return;
                    }
                }
                MySqlCommand checkStokCommand = new MySqlCommand("SELECT stok FROM products WHERE nama_produk = @namaProduk", conn);
                checkStokCommand.Parameters.AddWithValue("@namaProduk", namaProduk);
                int stok;

                using (MySqlDataReader reader = checkStokCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        stok = reader.GetInt32(0);
                        if (stok < qty)
                        {
                            MessageBox.Show("Stok produk tidak mencukupi.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan.");
                        return;
                    }
                }
                if (uangBayar < totalHarga)
                {
                    MessageBox.Show("Uang bayar kurang dari total harga.");
                    uangbyr.Text = "";
                    return;
                }
                MySqlCommand insertTransaksiCommand = new MySqlCommand("INSERT INTO transactions (id_produk, nama_pelanggan, qty, vote_pasukan, nomor_unik, uang_bayar, uang_kembali, total_harga, created_at) VALUES (@idProduk, @namaPelanggan, @qty, @votePasukan, @nomorUnik, @uangBayar, @uangKembalian, @totalHarga, NOW())", conn);
                insertTransaksiCommand.Parameters.AddWithValue("@idProduk", idProduk);
                insertTransaksiCommand.Parameters.AddWithValue("@namaPelanggan", namaPelanggan);
                insertTransaksiCommand.Parameters.AddWithValue("@qty", qty);
                insertTransaksiCommand.Parameters.AddWithValue("@votePasukan", votePasukan);
                insertTransaksiCommand.Parameters.AddWithValue("@nomorUnik", nomorUnik);
                insertTransaksiCommand.Parameters.AddWithValue("@uangBayar", uangBayar);
                insertTransaksiCommand.Parameters.AddWithValue("@uangKembalian", uangKembali);
                insertTransaksiCommand.Parameters.AddWithValue("@totalHarga", totalHarga);


                insertTransaksiCommand.ExecuteNonQuery();

                MySqlCommand reduceStokCommand = new MySqlCommand("UPDATE products SET stok = stok - @qty WHERE nama_produk = @namaproduk", conn);
                reduceStokCommand.Parameters.AddWithValue("@qty", qty);
                reduceStokCommand.Parameters.AddWithValue("@namaproduk", namaProduk);
                reduceStokCommand.ExecuteNonQuery();

                MessageBox.Show("Transaksi berhasil.");
                MessageBox.Show("cetak struk", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                laporan frm = new laporan();
                CrystalReport2 cr1 = new CrystalReport2();
               
                TextObject tanggalb = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["tanggalb"];
                tanggalb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                TextObject namapel = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["nampel"];
                namapel.Text = nampel.Text;
                TextObject nounik = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["nounik"];
                nounik.Text = nomorunik.Text;
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

                frm.crystalReportViewer1.ReportSource = cr1;
                frm.Show();

                clear();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                clear();
            }
        }

        private void cblkbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=nopas");

            conn.Open();
            if (cblkbb.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT harga_produk FROM products WHERE nama_produk = @nama_produk", conn);
                cmd.Parameters.AddWithValue("@nama_produk", cblkbb.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    harsat.Text = reader.GetDecimal(0).ToString();
                }
                else
                {
                    harsat.Text = "Not Found";
                }

                reader.Close();

                MySqlCommand cmdJumlahPeserta = new MySqlCommand("SELECT jumlah_peserta FROM products WHERE nama_produk = @nama_produk", conn);
                cmdJumlahPeserta.Parameters.AddWithValue("@nama_produk", cblkbb.Text);

                MySqlDataReader readerJumlahPeserta = cmdJumlahPeserta.ExecuteReader();

                int jumlahPeserta = 0;

                if (readerJumlahPeserta.Read())
                {
                    jumlahPeserta = readerJumlahPeserta.GetInt32(0);
                }

                readerJumlahPeserta.Close();

                cbpasvaf.Items.Clear();

                for (int i = 1; i <= jumlahPeserta; i++)
                {
                    cbpasvaf.Items.Add(i.ToString());
                }

                if (cbpasvaf.Items.Count > 0)
                {
                    cbpasvaf.SelectedIndex = 0;
                }

                conn.Close();
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nounik_TextChanged(object sender, EventArgs e)
        {

        }

        private void batal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void nampel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void datastok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < datastok.Rows.Count)
            {
                string productName = datastok.Rows[rowIndex].Cells["nama_produk"].Value.ToString();
                int stock = Convert.ToInt32(datastok.Rows[rowIndex].Cells["stok"].Value);

                MessageBox.Show($"Stok produk '{productName}' saat ini: {stock}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new historitransaksi().Show();
        }

        private void uangbyr_TextChanged(object sender, EventArgs e)
        {

        }

        private void harsat_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
    