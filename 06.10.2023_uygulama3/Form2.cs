using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06._10._2023_uygulama3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        List<string> musteriler = new List<string>();
        List<string> musteriBilgileri = new List<string>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdsoyad.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            decimal yas = numericUpDown1.Value;

            musteriler.Add(adSoyad);
            musteriBilgileri.Add($"Yaş: {yas} \nTelefon: {telefon}\nAdres:{adres}");
            txtAdres.Clear();
            txtTelefon.Clear();
            txtAdsoyad.Clear();
            numericUpDown1.Value = 0;

        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1(musteriler, musteriBilgileri)
            {
                Visible = true
            };





        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
         


            Form1 form1 = new Form1(musteriler, musteriBilgileri)
            {
                Visible = true
            };
        }
    }
}
