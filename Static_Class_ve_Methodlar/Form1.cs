using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Class_ve_Methodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FizikKutuphanesi.YerCekimiKuvveti.ToString());
            MessageBox.Show(FizikKutuphanesi.KaldirmaKuvveti.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bisiklet bsk = new Bisiklet();
            bsk.markasi = "Bianchi";
            bsk.rengi = "Mavi";
            bsk.tekerlek_capi = 21.2;
            bsk.vites_sayisi = 18;
            // bsk.satilan_bisiklet_sayisi++; // Bu değişken static olduğu için bu yazım hatalı.
            Bisiklet.satilan_bisiklet_sayisi++;

            Bisiklet bsk2 = new Bisiklet();
            bsk2.markasi = "Avroc";
            bsk2.rengi = "Kırmızı";
            bsk2.tekerlek_capi = 19.2;
            bsk2.vites_sayisi = 17;
            Bisiklet.satilan_bisiklet_sayisi++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(Bisiklet.satilan_bisiklet_sayisi.ToString());
        }
    }
}