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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Satislar", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["SatisID"].ToString();
                listViewItem.SubItems.Add(reader["SatisTarihi"].ToString());
                listViewItem.SubItems.Add(reader["Adres"].ToString());
                listViewItem.SubItems.Add(reader["Sehir"].ToString());
                listViewItem.SubItems.Add(reader["BirimFiyat"].ToString());
                listViewItem.SubItems.Add(reader["Miktar"].ToString());
                listViewItem.SubItems.Add(reader["PersonelID"].ToString());
                listViewItem.SubItems.Add(reader["MusteriID"].ToString());
                listViewItem.SubItems.Add(reader["UrunID"].ToString());

                siparisler_listView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            siparisler_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            siparisler_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void siparis_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siparisekle_btn_Click(object sender, EventArgs e)
        {
            SiparisEkle siparisekle = new SiparisEkle();
            siparisekle.Show();
        }

        private void sipariscıkar_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            for (int i = siparisler_listView.Items.Count - 1; i >= 0; i--)
            {
                if (siparisler_listView.Items[i].Selected)
                {
                    try
                    {

                        SqlCommand command = new SqlCommand($"DELETE FROM Satislar WHERE SatisID = {siparisler_listView.Items[i].Text}", sqlconnect.Baglanti);
                        int affectedRows = command.ExecuteNonQuery();

                        siparisler_listView.Items.RemoveAt(i);
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
