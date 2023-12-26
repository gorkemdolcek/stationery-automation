using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoldPencils
{
    public partial class AnasayfaPage : Form
    {
        public AnasayfaPage()
        {
            InitializeComponent();
        }

        private void satıs_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();




        }

        private void musteri_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();

            Musteri musteriPage = new Musteri();
            musteriPage.TopLevel = false;
            anasayfa_main_panel.Controls.Add(musteriPage);
            musteriPage.Dock = DockStyle.Fill;

            musteriPage.Show();

        }

        private void AnasayfaPage_Load(object sender, EventArgs e)
        {

        }

        private void urunler_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();

            Urun urunPage = new Urun();
            urunPage.TopLevel = false;
            anasayfa_main_panel.Controls.Add(urunPage);
            urunPage.Dock = DockStyle.Fill;

            urunPage.Show();

        }

        private void personel_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();

            Personel personelPage = new Personel();
            personelPage.TopLevel = false;
            anasayfa_main_panel.Controls.Add(personelPage);
            personelPage.Dock = DockStyle.Fill;

            personelPage.Show();
        }

        private void depo_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();

            Depo depoPage = new Depo();
            depoPage.TopLevel = false;
            anasayfa_main_panel.Controls.Add(depoPage);
            depoPage.Dock = DockStyle.Fill;

            depoPage.Show();
        }

        private void tedarikci_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();

            Tedarikci tedarikciPage = new Tedarikci();
            tedarikciPage.TopLevel = false;
            anasayfa_main_panel.Controls.Add(tedarikciPage);
            tedarikciPage.Dock = DockStyle.Fill;

            tedarikciPage.Show();
        }

        private void stok_btn_Click(object sender, EventArgs e)
        {
            anasayfa_main_panel.Controls.Clear();

            Stok stokPage = new Stok();
            stokPage.TopLevel = false;
            anasayfa_main_panel.Controls.Add(stokPage);
            stokPage.Dock = DockStyle.Fill;

            stokPage.Show();
        }
    }
}
