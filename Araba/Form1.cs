using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Araba.Arabalar;

namespace Araba
{
    public partial class Form1 : Form
    {
         Cars araba;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            araba = new Cars();
            araba.Id =Int32.Parse(txtArabaId.Text);
            araba.Marka = txtMarka.Text;
            araba.Model = txtModel.Text;
            araba.KapiSayisi = cmbKapiSayisi.Text;
            araba.BeygirGucu = double.Parse(txtBeygirGucu.Text);
            araba.ArabaTuru = (ArabaTuru)chbBinek.TextAlign;
            araba.MaksimumHiz = double.Parse(txtMaksimumHiz.Text);
            araba.Cekis = cmbCekis.Text;
            araba.SifirdanYuze = double.Parse(txtHizlanma.Text);
            araba.Agirlik=double.Parse(txtAgirlik.Text);
            araba.MotorHacmi=double.Parse(txtMotorHacmi.Text);

            
            string yazdir = "ID : " + araba.Id + "\nMarka: " + araba.Marka + "\nModel: " + araba.Model + "\nKapi Sayisi: " +
                     araba.KapiSayisi + "" +
                     "\nBeygir Gucu: " + araba.BeygirGucu + " beygir" + "\nAraba Turu: " +
                     (chbBinek.Checked ? "Binek" : "Ticari")
                     + "\nMaksimum Hiz: " + araba.MaksimumHiz + " k\\s" + "\nCekis: " + araba.Cekis +
                     "\nSifirdan Yuze: " +
                     araba.SifirdanYuze + " saniyede" +
                     "\nAgirlik: " + araba.Agirlik + " kg" + "\nMotor Hacmi: " + araba.MotorHacmi + " santimetre kup.";
            MessageBox.Show(yazdir, "Araba Ozellikleri", MessageBoxButtons.OK);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           Close();
            
        }
    }
}
