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
    public partial class Berandakasir : Form
    {
        Data bt = new Data();
        public Berandakasir()
        {
            InitializeComponent();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Akan Keluar?", "Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bt.command("insert into log (id_user, activity, created_at) VALUES ('" + Data.id_user + "', 'Logout', NOW())");
                this.Hide();
                new Login().Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide ();
            new Transaksi().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new cetakulang().Show();
        }

        private void Berandakasir_Load(object sender, EventArgs e)
        {
            lbnama.Text = "hi, " + Data.nama + "!";
        }
    }
}
