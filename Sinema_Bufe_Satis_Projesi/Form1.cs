using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,cocacola,cikolata,toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            cocacola = Convert.ToInt16(txtCola.Text);
            cikolata = Convert.ToInt16(txtCikolata.Text);
            
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8+cocacola*3+cikolata*5;
            lblToplam.Text = toplam.ToString()+"TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            txtCola.Text = "";
            txtCikolata.Text = "";
            txtMisir.Focus();
        }
    }
}
