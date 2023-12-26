using System.Data.SqlClient;

namespace BoldPencils
{
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }

        private void siparisEkleButton_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Satislar(SatisID, SatisTarihi, Adres, Sehir, BirimFiyat, Miktar, PersonelID, MusteriID, UrunID) VALUES({satisID_sql.Text},'{satisTarihi_sql.Text}','{adres_sql.Text}','{sehir_sql.Text}',{birimfiyat_sql.Text},{miktar_sql.Text},{personelid_sql.Text},{musteriid_sql.Text},{urunid_sql.Text});", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                MessageBox.Show("İşlem başarılı! Listenizi güncellemek için ürünler butonuna tekrar tıklayın.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
