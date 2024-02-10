using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOPAS
{
    internal class Data
    {

        public static string role;
        public static string nama;
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=nopas");
       
        private Form activateForm;
        public static string username = "";
        public static string id_user = "";

        public void openChildForm(Form childForm, Panel panel, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel.Controls.Add(childForm);
            panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        public void command(string query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
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
        public void ShowForm1AsDialog()
        {
            historitransaksi form1 = new historitransaksi();
            form1.ShowDialog();
        }

        public void showData(string query, DataGridView dg)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dg.DataSource = dt;
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
            
        public void GetDataNamaLkbb(ComboBox cb)
        {
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT nama_produk FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cb.Items.Add(reader["nama_produk"].ToString());
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
        public void GetDataDays(ComboBox cb)
        {
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT days FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cb.Items.Add(reader["days"].ToString());
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
        public void showDg(string query, DataGridView dgv)
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}