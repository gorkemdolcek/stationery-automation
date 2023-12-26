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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void siparisEkleButton_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Personeller(PersonelID, Adi, SoyAdi, Telefon, Email, Maas, Sehir, Bolge) VALUES({personelID_sql.Text},'{adi_sql.Text}','{soyadi_sql.Text}','{telefon_sql.Text}','{email_sql.Text}','{maas_sql.Text}','{sehir_sql.Text}','{bolge_sql.Text}');", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                MessageBox.Show("İşlem başarılı! Listenizi güncellemek için personeller butonuna tekrar tıklayın.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
