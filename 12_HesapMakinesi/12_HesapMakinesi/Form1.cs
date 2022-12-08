using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char islem;
        bool ekranTemizMi = false;
        double sayi1;



        private void btn1_Click(object sender, EventArgs e)
        {

            if(ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if(lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 1;

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {if (ekranTemizMi == true)
            {
                lblSonuc.Text = "0";
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ekranTemizMi == true)
            {
                lblSonuc.Text = "0";
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        { 
            if (ekranTemizMi == true)
            {
                lblSonuc.Text = "0";
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ekranTemizMi)
            {
                lblSonuc.Text = "0";
                ekranTemizMi = false;
            }

            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = "";
            }
            lblSonuc.Text += 0;
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizMi = true;
            sayi1 = Convert.ToDouble(lblSonuc.Text);
        }

        private void btnCikartma_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizMi = true;
            sayi1 = Convert.ToDouble(lblSonuc.Text);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            islem = 'x';
            ekranTemizMi = true;
            sayi1 = Convert.ToDouble(lblSonuc.Text);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizMi = true;
            sayi1 = Convert.ToDouble(lblSonuc.Text);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            double sayi2 = Convert.ToDouble(lblSonuc.Text);

            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
            }

            lblSonuc.Text = sonuc.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0";
        }
    }
}
