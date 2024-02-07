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
    public partial class Berandaowner : Form
    {
        public Berandaowner()
        {
            InitializeComponent();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Akan Keluar?", "Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogAktivity().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new laporantransaksi().Show();
        }

        private void Berandaowner_Load(object sender, EventArgs e)
        {
            lbnama.Text = "hi, " + Data.nama + "!";
        }
    }
}
