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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Personeller", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["PersonelID"].ToString();
                listViewItem.SubItems.Add(reader["Adi"].ToString());
                listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                listViewItem.SubItems.Add(reader["Telefon"].ToString());
                listViewItem.SubItems.Add(reader["Email"].ToString());
                listViewItem.SubItems.Add(reader["Maas"].ToString());
                listViewItem.SubItems.Add(reader["Sehir"].ToString());
                listViewItem.SubItems.Add(reader["Bolge"].ToString());

                personel_listview1.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void satıs_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand($"SELECT * FROM Personeller WHERE CONCAT(PersonelID, Adi, SoyAdi, Telefon, Email, Maas, Sehir, Bolge) LIKE '%{personel_search_textBox.Text}%';", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            personel_listview1.Items.Clear();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["PersonelID"].ToString();
                listViewItem.SubItems.Add(reader["Adi"].ToString());
                listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                listViewItem.SubItems.Add(reader["Telefon"].ToString());
                listViewItem.SubItems.Add(reader["Email"].ToString());
                listViewItem.SubItems.Add(reader["Maas"].ToString());
                listViewItem.SubItems.Add(reader["Sehir"].ToString());
                listViewItem.SubItems.Add(reader["Bolge"].ToString());
                personel_listview1.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void azsirala_Click(object sender, EventArgs e)
        {
            personel_listview1.Items.Clear();
            if (personel_listview1.Text.Length == 0)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand("SELECT * FROM Personeller ORDER BY Adi ASC", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["PersonelID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Maas"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    personel_listview1.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (personel_listview1.Text.Length >= 1)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Personeller WHERE CONCAT(PersonelID, Adi, SoyAdi, Telefon, Email, Maas, Sehir, Bolge) LIKE '%{personel_search_textBox.Text}%' ORDER BY Adi ASC;", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["PersonelID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Maas"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    personel_listview1.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            };
        }

        private void zasirala_Click(object sender, EventArgs e)
        {
            personel_listview1.Items.Clear();
            if (personel_listview1.Text.Length == 0)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand("SELECT * FROM Personeller ORDER BY Adi ASC", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["PersonelID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Maas"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    personel_listview1.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (personel_listview1.Text.Length >= 1)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Personeller WHERE CONCAT(PersonelID, Adi, SoyAdi, Telefon, Email, Maas, Sehir, Bolge) LIKE '%{personel_search_textBox.Text}%' ORDER BY Adi DESC;", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["PersonelID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Maas"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    personel_listview1.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                personel_listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            };
        }

        private void personelekle_btn_Click(object sender, EventArgs e)
        {
            PersonelEkle personelekle = new PersonelEkle();
            personelekle.Show();
        }

        private void personelcıkar_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            for (int i = personel_listview1.Items.Count - 1; i >= 0; i--)
            {
                if (personel_listview1.Items[i].Selected)
                {
                    try
                    {

                        SqlCommand command = new SqlCommand($"DELETE FROM Personeller WHERE PersonelID = {personel_listview1.Items[i].Text}", sqlconnect.Baglanti);
                        int affectedRows = command.ExecuteNonQuery();

                        personel_listview1.Items.RemoveAt(i);
                    }
                    catch
                    {
                        MessageBox.Show("bruh moment code 3: delete unsuccessfull");
                    }

                }
            }
        }

        private void personelmaasdusur_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            for (int i = personel_listview1.Items.Count - 1; i >= 0; i--)
            {
                if (personel_listview1.Items[i].Selected)
                {
                    try
                    {

                        SqlCommand command = new SqlCommand($"UPDATE Personeller SET MAAS = {textBox1.Text} WHERE PersonelID= {personel_listview1.Items[i].Text}", sqlconnect.Baglanti);
                        int affectedRows = command.ExecuteNonQuery();
                        MessageBox.Show("İşlem başarılı! Listeyi güncellemek için personeller sekmesine tekrardan tıklayınız.");

                    }
                    catch
                    {
                        MessageBox.Show("bruh moment code 3: delete unsuccessfull");
                    }

                }
            }
        }
    }
}
