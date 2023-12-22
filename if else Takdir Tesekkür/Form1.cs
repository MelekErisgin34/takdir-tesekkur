using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_Takdir_Tesekkür
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolet_Click(object sender, EventArgs e)
        {
            float ortalama;
            ortalama = Convert.ToSingle(txtOrtalamaniz.Text);
            if (ortalama < 0)
            {
                lblSonuc.Text = "Negatif Değer Giremezsin";
            }
            else if (ortalama < 50)
            {
                lblSonuc.Text = "Kaldınız:( ";
            }
            else if (ortalama < 70)
            {
                lblSonuc.Text = "Tebrikler.Geçtiniz.";
            }
            else if (ortalama < 85)
            {
                lblSonuc.Text = "Teşekkür Belgesi Aldınız";
            }
            else if (ortalama <= 100)
            {
                lblSonuc.Text = "Takdir Belgesi Aldınız";
            }
            else
            {
                lblSonuc.Text = "'100'den Büyük Not Giremezsin!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = " ";
        }
    }
}
