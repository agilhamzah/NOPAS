using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NOPAS
{
    public partial class User : Form
    {
        string id;
      
        public User()
        {
            InitializeComponent();
        }

        Data u = new Data();
        bool isEditMode = false;

        void clear()
        {
            id = string.Empty;
            username.Text = string.Empty;
            pw.Text = string.Empty;
            namleng.Text = string.Empty;
            role.Text = string.Empty;
            u.showData("Select * from users", dataGridView1);
        }
  

        private void tambah_Click(object sender, EventArgs e)
        {
            // Logika mode tambah
            if (isEditMode)
            {
                // Logika mode edit
                DialogResult editResult = MessageBox.Show("Anda yakin ingin mengedit user?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (editResult == DialogResult.Yes)
                {
                    u.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Admin Mengubah user', NOW())");
                    MessageBox.Show("Anda telah mengubah user", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (username.Text == string.Empty || pw.Text == string.Empty || namleng.Text == string.Empty || role.Text == string.Empty)
                    {
                        MessageBox.Show("Semua kolom harus di isi!");
                    }
                    else
                    {
                        u.command("update users set username = '" + username.Text + "', password = '" + pw.Text + "', nama = '" + namleng.Text + "', role = '" + role.Text + "', updated_at = NOW() where id = '" + id + "' ");
                        clear();

                        // Kembali ke mode tambah
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
                DialogResult result = MessageBox.Show("Anda yakin ingin menambah user?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    clear();
                }

                if (result == DialogResult.Yes)
                {
                    u.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Admin Menambahkan user', NOW())");
                    MessageBox.Show("Anda telah menambahkan user", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (username.Text == string.Empty || pw.Text == string.Empty || namleng.Text == string.Empty || role.Text == string.Empty)
                    {
                        MessageBox.Show("Semua kolom harus di isi!");
                    }
                    else
                    {
                        string query = "INSERT INTO users ( username, password, nama, role, created_at) VALUES ( '" + username.Text + "', '" + pw.Text + "', '" + namleng.Text + "', '" + role.Text + "', NOW() )";
                        u.command(query);
                        clear();
                    }
                }
                else
                {
                    clear();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            clear();

            lbnama.Text = "hi, " + Data.nama + "!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Logout', NOW())");
            this.Close();
            new Login().Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            clear();
            isEditMode = false;
            tambah.Text = "Tambah";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];

            username.Text = dr.Cells[1].Value.ToString();
            pw.Text = dr.Cells[2].Value.ToString();
            namleng.Text = dr.Cells[3].Value.ToString();
            role.Text = dr.Cells[4].Value.ToString();

            id = dr.Cells[0].Value.ToString();
            isEditMode = true;
            tambah.Text = "Edit";
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            {
                u.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Admin Mengahapus user', NOW())");
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo);
               
                if (result == DialogResult.Yes)
                {
                    u.command("delete from users where username = '" + username.Text + "' ");
                    MessageBox.Show("User berhasil di hapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    u.command("insert into log (id_user, activity, created_at) VALUES('" + Data.id_user + "', 'Admin menghapus user', NOW())");
                    clear();

                    isEditMode = false;
                    tambah.Text = "Tambah";
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new Berandaadmin().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE username LIKE '%" + cari.Text + "%' OR nama LIKE '%" + cari.Text + "%'";
            u.showData(query, dataGridView1);
        }
    }
}
