using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizefinalnotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ort=0;
            vize=Convert.ToDouble(txtVize.Text);
            final=Convert.ToDouble(txtFinal.Text);
            ort = vize * 0.4 + final * 0.6;
            lblOrt.Text ="Ortalamanız: "+ort.ToString();
            if (vize >= 50 && final>=50)
            {
                lblDurum.Text = "Geçti";
            }
            else
            {
                lblDurum.Text = "Kaldı";
            }
        }
    }
}
