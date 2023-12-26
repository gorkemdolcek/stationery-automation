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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BoldPencils
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteriler", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["MusteriID"].ToString();
                listViewItem.SubItems.Add(reader["Adi"].ToString());
                listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                listViewItem.SubItems.Add(reader["Sehir"].ToString());
                listViewItem.SubItems.Add(reader["Bolge"].ToString());
                listViewItem.SubItems.Add(reader["Email"].ToString());
                listViewItem.SubItems.Add(reader["Telefon"].ToString());
                musteri_listView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void musteri_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verileriver_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand($"SELECT * FROM Musteriler WHERE CONCAT(MusteriID, Adi, SoyAdi, Sehir, Bolge, Email, Telefon) LIKE '%{musteri_search_textBox.Text}%';", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            musteri_listView.Items.Clear();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["MusteriID"].ToString();
                listViewItem.SubItems.Add(reader["Adi"].ToString());
                listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                listViewItem.SubItems.Add(reader["Sehir"].ToString());
                listViewItem.SubItems.Add(reader["Bolge"].ToString());
                listViewItem.SubItems.Add(reader["Email"].ToString());
                listViewItem.SubItems.Add(reader["Telefon"].ToString());
                musteri_listView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void azsirala_Click(object sender, EventArgs e)
        {
            musteri_listView.Items.Clear();
            if (musteri_search_textBox.Text.Length == 0)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand("SELECT * FROM Musteriler ORDER BY Adi ASC", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["MusteriID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    musteri_listView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (musteri_search_textBox.Text.Length >= 1) {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Musteriler WHERE CONCAT(MusteriID, Adi, SoyAdi, Sehir, Bolge, Email, Telefon) LIKE '%{musteri_search_textBox.Text}%' ORDER BY Adi ASC;", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["MusteriID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    musteri_listView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            } ;
           

        }

        private void zasirala_Click(object sender, EventArgs e)
        {
            musteri_listView.Items.Clear();
            if (musteri_search_textBox.Text.Length == 0)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand("SELECT * FROM Musteriler ORDER BY Adi DESC", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["MusteriID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    musteri_listView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (musteri_search_textBox.Text.Length >= 1)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Musteriler WHERE CONCAT(MusteriID, Adi, SoyAdi, Sehir, Bolge, Email, Telefon) LIKE '%{musteri_search_textBox.Text}%' ORDER BY Adi DESC;", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["MusteriID"].ToString();
                    listViewItem.SubItems.Add(reader["Adi"].ToString());
                    listViewItem.SubItems.Add(reader["SoyAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    listViewItem.SubItems.Add(reader["Email"].ToString());
                    listViewItem.SubItems.Add(reader["Telefon"].ToString());
                    musteri_listView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                musteri_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            };


        }
    }
}
