using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoldPencils
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void siparisEkleButton_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Urunler(UrunID, UrunAdi, Fiyat, StokDurumu, KategoriID, TedarikciID) VALUES({urunID_sql.Text},'{urunAdi_sql.Text}','{fiyat_sql.Text}','{stokdurumu_sql.Text}',{kategoriid_sql.Text},{tedarikciid_sql.Text});", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                MessageBox.Show("İşlem başarılı! Listenizi güncellemek için siparişler butonuna tekrar tıklayın.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
