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
    public partial class Depo : Form
    {
        public Depo()
        {

            InitializeComponent();
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Depolar", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["DepoID"].ToString();
                listViewItem.SubItems.Add(reader["DepoDetayID"].ToString());
                listViewItem.SubItems.Add(reader["UrunID"].ToString());
                listViewItem.SubItems.Add(reader["UrunAdet"].ToString());


                depo_ListView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            depo_ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            depo_ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void depo_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depo_ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depo_btn_Click(object sender, EventArgs e)
        {
            depo_ListView.Visible = true;
            depodetay_listView.Visible = false;
            depotransfer_listView.Visible = false;

        }

        private void depodetay_btn_Click(object sender, EventArgs e)
        {
            depodetay_listView.Visible = true;
            depo_ListView.Visible = false;
            depotransfer_listView.Visible = false;
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM DepoDetay", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["DepoDetayID"].ToString();
                listViewItem.SubItems.Add(reader["Sehir"].ToString());
                listViewItem.SubItems.Add(reader["Bolge"].ToString());
                listViewItem.SubItems.Add(reader["PersonelSayisi"].ToString());


                depodetay_listView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            depodetay_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            depodetay_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void depotransfer_btn_Click(object sender, EventArgs e)
        {
            depotransfer_listView.Visible = true;
            depodetay_listView.Visible = false;
            depo_ListView.Visible = false;
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM DepoTransferleri", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["TransferID"].ToString();
                listViewItem.SubItems.Add(reader["UrunID"].ToString());
                listViewItem.SubItems.Add(reader["KaynakDepoID"].ToString());
                listViewItem.SubItems.Add(reader["HedefDepoID"].ToString());
                listViewItem.SubItems.Add(reader["TransferMiktar"].ToString());
                listViewItem.SubItems.Add(reader["TransferTarihi"].ToString());



                depotransfer_listView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();

            depotransfer_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            depotransfer_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void depo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void depodetay_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depotransfer_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (depo_ListView.Visible == true)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM Depolar WHERE CONCAT(DepoID, DepoDetayID, UrunID, UrunAdet) LIKE '%{depo_search_textBox.Text}%';", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                depo_ListView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["DepoID"].ToString();
                    listViewItem.SubItems.Add(reader["DepoDetayID"].ToString());
                    listViewItem.SubItems.Add(reader["UrunID"].ToString());
                    listViewItem.SubItems.Add(reader["UrunAdet"].ToString());
                    depo_ListView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                depo_ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                depo_ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            else if (depodetay_listView.Visible == true)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM DepoDetay WHERE CONCAT(DepoDetayID, Sehir, Bolge, PersonelSayisi) LIKE '%{depo_search_textBox.Text}%';", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                depodetay_listView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["DepoDetayID"].ToString();
                    listViewItem.SubItems.Add(reader["Sehir"].ToString());
                    listViewItem.SubItems.Add(reader["Bolge"].ToString());
                    listViewItem.SubItems.Add(reader["PersonelSayisi"].ToString());
                    depodetay_listView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                depodetay_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                depodetay_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (depotransfer_listView.Visible == true)
            {
                sqlconnect sqlconnect = new sqlconnect();
                sqlconnect.ConnectionOpen();
                SqlCommand command = new SqlCommand($"SELECT * FROM DepoTransferleri WHERE CONCAT(TransferID, UrunID, KaynakDepoID, HedefDepoID, TransferMiktar, TransferTarihi) LIKE '%{depo_search_textBox.Text}%';", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                depotransfer_listView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader["TransferID"].ToString();
                    listViewItem.SubItems.Add(reader["UrunID"].ToString());
                    listViewItem.SubItems.Add(reader["KaynakDepoID"].ToString());
                    listViewItem.SubItems.Add(reader["HedefDepoID"].ToString());
                    listViewItem.SubItems.Add(reader["TransferMiktar"].ToString());
                    listViewItem.SubItems.Add(reader["TransferTarihi"].ToString());

                    depotransfer_listView.Items.Add(listViewItem);
                }

                reader.Close();
                sqlconnect.Baglanti.Close();

                depotransfer_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                depotransfer_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
    }
}
