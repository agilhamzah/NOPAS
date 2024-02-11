using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NOPAS
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=nopas");  
        Data l = new Data();
        void login()
        {
            try
            {
                conn.Open();
                // Mengecek apakah tombol Caps Lock aktif
                bool isCapsLockActive = Control.IsKeyLocked(Keys.CapsLock);

                // Jika Caps Lock aktif, berikan peringatan kepada pengguna
                if (isCapsLockActive)
                {
                    MessageBox.Show("Caps Lock aktif. Harap perhatikan penggunaan huruf besar/kecil pada kata sandi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM users WHERE username='" + textBox1.Text + "' AND password='" + pw.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Data.role = dr["role"].ToString();
                        Data.id_user = dr["id"].ToString();
                        Data.nama = dr["nama"].ToString();

                        // Masukkan entri log hanya jika rolenya bukan "owner"
                        if (Data.role != "owner")
                        {
                            l.command("INSERT INTO log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'login', NOW())");
                        }

                        MessageBox.Show("Login Berhasil !", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (Data.role == "admin")
                        {
                            this.Hide();
                            new Berandaadmin().Show();
                        }
                        else if (Data.role == "kasir")
                        {
                            this.Hide();
                            new Berandakasir().Show();
                        }
                        else if (Data.role == "owner")
                        {
                            this.Hide();
                            new Berandaowner().Show();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Akun Tidak Ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public Login()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                pw.UseSystemPasswordChar = false;
            }
            else
            {
                pw.UseSystemPasswordChar = true;  
            }
        }
    }
    
}
