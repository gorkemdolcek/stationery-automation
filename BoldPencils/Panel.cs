using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BoldPencils
{
    public partial class Panel : Form
    {
        public Panel()
        {
        sqlconnect sqlconnect = new sqlconnect();
        sqlconnect.ConnectionOpen();
        InitializeComponent();

        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            AnasayfaPage anasayfapage = new AnasayfaPage();
            anasayfapage.TopLevel = false;
            anasayfapage.AutoScroll = true;
            page_panel.Controls.Add(anasayfapage);
            anasayfapage.Show();
        }

        private void kategori_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            Kategori kategoripage = new Kategori();
            kategoripage.TopLevel = false;
            kategoripage.AutoScroll = true;
            page_panel.Controls.Add(kategoripage);
            kategoripage.Show();
        }

        private void rapor_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

        }

        private void sipariş_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            Siparis siparispage = new Siparis();
            siparispage.TopLevel = false;
            siparispage.AutoScroll = true;
            page_panel.Controls.Add(siparispage);
            siparispage.Show();
        }

        private void emek_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            Yapanlar yapanlarpage = new Yapanlar();
            yapanlarpage.TopLevel = false;
            yapanlarpage.AutoScroll = true;
            page_panel.Controls.Add(yapanlarpage);
            yapanlarpage.Show();
        }

        private void cikisyap_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void page_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
