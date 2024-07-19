using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlkelHesapMakinesi
{
    public partial class Form1 : Form
    {
        string ekran="";
        string islem;
        int s1, s2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            txbEkran.Text = ekran+ "1";
            ekran = txbEkran.Text;
            
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "2";
            ekran = txbEkran.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "3";
            ekran = txbEkran.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "4";
            ekran = txbEkran.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "5";
            ekran = txbEkran.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "6";
            ekran = txbEkran.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "7";
            ekran = txbEkran.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "8";
            ekran = txbEkran.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "9";
            ekran = txbEkran.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txbEkran.Text = ekran + "0";
            ekran = txbEkran.Text;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            
            s1 = Convert.ToInt32(ekran);
            ekran = "";
            txbEkran.Text = "";
            islem = "+";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ekran = "";
            txbEkran.Text = "";
        }

        private void btnDE_Click(object sender, EventArgs e)
        {
            string kesilenStr=txbEkran.Text;
            int adet = kesilenStr.Length - 1;
            
            txbEkran.Text = kesilenStr.Substring(0, adet);
            ekran = txbEkran.Text;

        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            
            s2 = Convert.ToInt32(ekran);
            txbEkran.Text = Convert.ToString(s1 + s2);
            ekran = "";



        }
    }
}
