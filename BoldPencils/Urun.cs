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
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Urunler", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["UrunID"].ToString();
                listViewItem.SubItems.Add(reader["UrunAdi"].ToString());
                listViewItem.SubItems.Add(reader["Fiyat"].ToString());
                listViewItem.SubItems.Add(reader["StokDurumu"].ToString());
                listViewItem.SubItems.Add(reader["KategoriID"].ToString());
                listViewItem.SubItems.Add(reader["TedarikciID"].ToString());
                urunlistview.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            for (int i = urunlistview.Items.Count - 1; i >= 0; i--)
            {
                if (urunlistview.Items[i].Selected)
                {
                    try
                    {

                        SqlCommand command = new SqlCommand($"DELETE FROM Urunler WHERE UrunID = {urunlistview.Items[i].Text}", sqlconnect.Baglanti);
                        int affectedRows = command.ExecuteNonQuery();

                        urunlistview.Items.RemoveAt(i);
                    }
                    catch
                    {
                        MessageBox.Show("bruh moment code 3: delete unsuccessfull");
                    }

                }
            }
        }
        private void urun_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verileriver_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand($"SELECT * FROM Urunler WHERE CONCAT(UrunID, UrunAdi, Fiyat, StokDurumu, KategoriID, TedarikciID) LIKE '%{urun_search_textBox.Text}%';", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            urunlistview.Items.Clear();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["UrunID"].ToString();
                listViewItem.SubItems.Add(reader["UrunAdi"].ToString());
                listViewItem.SubItems.Add(reader["Fiyat"].ToString());
                listViewItem.SubItems.Add(reader["StokDurumu"].ToString());
                listViewItem.SubItems.Add(reader["KategoriID"].ToString());
                listViewItem.SubItems.Add(reader["TedarikciID"].ToString());
                urunlistview.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void azdancok_radiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void azsirala_Click(object sender, EventArgs e)
        {
            urunlistview.Items.Clear();
            if (urun_search_textBox.Text.Length == 0)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand("SELECT * FROM Urunler ORDER BY UrunAdi ASC", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["UrunID"].ToString();
                    listViewItem.SubItems.Add(reader["UrunAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Fiyat"].ToString());
                    listViewItem.SubItems.Add(reader["StokDurumu"].ToString());
                    listViewItem.SubItems.Add(reader["KategoriID"].ToString());
                    listViewItem.SubItems.Add(reader["TedarikciID"].ToString());
                    urunlistview.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (urun_search_textBox.Text.Length >= 1)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Urunler WHERE CONCAT(UrunID, UrunAdi, Fiyat, StokDurumu, KategoriID, TedarikciID) LIKE '%{urun_search_textBox.Text}%' ORDER BY UrunAdi ASC;", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["UrunID"].ToString();
                    listViewItem.SubItems.Add(reader["UrunAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Fiyat"].ToString());
                    listViewItem.SubItems.Add(reader["StokDurumu"].ToString());
                    listViewItem.SubItems.Add(reader["KategoriID"].ToString());
                    listViewItem.SubItems.Add(reader["TedarikciID"].ToString());
                    urunlistview.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            };
        }

        private void zasirala_Click(object sender, EventArgs e)
        {
            urunlistview.Items.Clear();
            if (urun_search_textBox.Text.Length == 0)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand("SELECT * FROM Urunler ORDER BY UrunAdi DESC", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["UrunID"].ToString();
                    listViewItem.SubItems.Add(reader["UrunAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Fiyat"].ToString());
                    listViewItem.SubItems.Add(reader["StokDurumu"].ToString());
                    listViewItem.SubItems.Add(reader["KategoriID"].ToString());
                    listViewItem.SubItems.Add(reader["TedarikciID"].ToString());
                    urunlistview.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (urun_search_textBox.Text.Length >= 1)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Urunler WHERE CONCAT(UrunID, UrunAdi, Fiyat, StokDurumu, KategoriID, TedarikciID) LIKE '%{urun_search_textBox.Text}%' ORDER BY UrunAdi DESC;", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["UrunID"].ToString();
                    listViewItem.SubItems.Add(reader["UrunAdi"].ToString());
                    listViewItem.SubItems.Add(reader["Fiyat"].ToString());
                    listViewItem.SubItems.Add(reader["StokDurumu"].ToString());
                    listViewItem.SubItems.Add(reader["KategoriID"].ToString());
                    listViewItem.SubItems.Add(reader["TedarikciID"].ToString());
                    urunlistview.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                urunlistview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            };
        }

        private void yıllıkcokurun_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT TOP 3 S.UrunID, SUM(S.Miktar) AS ToplamMiktar, U.UrunAdi FROM Satislar AS S JOIN Urunler AS U ON S.UrunID = U.UrunID WHERE S.SatisTarihi >= DATEADD(year, -1, GETDATE()) GROUP BY S.UrunID, U.UrunAdi ORDER BY SUM(S.Miktar) DESC;", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            String output = "";

            while (reader.Read())
            {
                output += " Ürün ID: ";
                output += reader["UrunID"].ToString();
                output += " Satış Miktarı: ";
                output += reader["ToplamMiktar"].ToString(); ;
                output += " Ürün Adı: ";
                output += reader["UrunAdi"].ToString();
                output += "\n";

            }
            MessageBox.Show(output);
            reader.Close();
            sqlconnect.Baglanti.Close();

        }

        private void aylıkcokurun_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT TOP 3 S.UrunID, SUM(S.Miktar) AS ToplamMiktar, U.UrunAdi FROM Satislar AS S JOIN Urunler AS U ON S.UrunID = U.UrunID WHERE S.SatisTarihi >= DATEADD(month, -1, GETDATE()) GROUP BY S.UrunID, U.UrunAdi ORDER BY SUM(S.Miktar) DESC;", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            String output = "";

            while (reader.Read())
            {
                output += " Ürün ID: ";
                output += reader["UrunID"].ToString();
                output += " Satış Miktarı: ";
                output += reader["ToplamMiktar"].ToString(); ;
                output += " Ürün Adı: ";
                output += reader["UrunAdi"].ToString();
                output += "\n";

            }
            MessageBox.Show(output);
            reader.Close();
            sqlconnect.Baglanti.Close();
        }

        private void yıllıkazurun_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT TOP 3 S.UrunID, SUM(S.Miktar) AS ToplamMiktar, U.UrunAdi FROM Satislar AS S JOIN Urunler AS U ON S.UrunID = U.UrunID WHERE S.SatisTarihi >= DATEADD(year, -1, GETDATE()) GROUP BY S.UrunID, U.UrunAdi ORDER BY SUM(S.Miktar) ASC;", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            String output = "";

            while (reader.Read())
            {
                output += " Ürün ID: ";
                output += reader["UrunID"].ToString();
                output += " Satış Miktarı: ";
                output += reader["ToplamMiktar"].ToString(); ;
                output += " Ürün Adı: ";
                output += reader["UrunAdi"].ToString();
                output += "\n";

            }
            MessageBox.Show(output);
            reader.Close();
            sqlconnect.Baglanti.Close();

        }

        private void aylıkazurun_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT TOP 3 S.UrunID, SUM(S.Miktar) AS ToplamMiktar, U.UrunAdi FROM Satislar AS S JOIN Urunler AS U ON S.UrunID = U.UrunID WHERE S.SatisTarihi >= DATEADD(month, -1, GETDATE()) GROUP BY S.UrunID, U.UrunAdi ORDER BY SUM(S.Miktar) ASC;", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            String output = "";

            while (reader.Read())
            {
                output += " Ürün ID: ";
                output += reader["UrunID"].ToString();
                output += " Satış Miktarı: ";
                output += reader["ToplamMiktar"].ToString(); ;
                output += " Ürün Adı: ";
                output += reader["UrunAdi"].ToString();
                output += "\n";

            }
            MessageBox.Show(output);
            reader.Close();
            sqlconnect.Baglanti.Close();
        }
    }
}
