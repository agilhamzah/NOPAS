using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
