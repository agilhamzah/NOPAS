using System;
using System.Collections;
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
    public partial class LogAktivity : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=nopas");
        Data a = new Data();

        public LogAktivity()
        {
            InitializeComponent();
        }
      
        private void LoadData()
        {
           
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string query = "SELECT l.id, l.id_user, u.nama, u.role, l.activity, l.created_at " +
               "FROM log l " +
               "JOIN users u ON l.id_user = u.id " +
               "ORDER BY l.id ASC"; 

            a.showData(query, dglogakt);
            lbnama.Text = "hi, " + Data.nama + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Berandaowner().Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridViewRow dr = this.dglogakt.Rows[e.RowIndex];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new laporantransaksi().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
