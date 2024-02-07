using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOPAS
{
    public partial class Berandaadmin : Form
    {
        Data a = new Data();
        public Berandaadmin()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Akan Keluar?", "Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                a.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Logout', NOW())");
                this.Hide();
                new Login().Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void Berandaadmin_Load(object sender, EventArgs e)
        {
            lbnama.Text = "hi, " + Data.nama + "!";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Produk().Show();
        }
    }
}
