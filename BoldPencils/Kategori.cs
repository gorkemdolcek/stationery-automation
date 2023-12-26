using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoldPencils
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Kategoriler", sqlconnect.Baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["KategoriID"].ToString();
                listViewItem.SubItems.Add(reader["KategoriAdi"].ToString());
                kategorilerListView.Items.Add(listViewItem);
            }

            reader.Close();
            sqlconnect.Baglanti.Close();



            kategorilerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            kategorilerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void kategori_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kategori_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kategoriekle_btn_Click(object sender, EventArgs e)
        {
            string[] parcalar = kategori_textBox.Text.Split(',');
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Kategoriler(KategoriID, KategoriAdi) VALUES({parcalar[0]}, '{parcalar[1]}');", sqlconnect.Baglanti);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = parcalar[0].ToString();
                listViewItem.SubItems.Add(parcalar[1].ToString());
                kategorilerListView.Items.Add(listViewItem);
            }
            catch
            {
                MessageBox.Show("Aynı ID ile kayıtlı bir kategori var!");
            }

         
            kategorilerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            kategorilerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void kategoricıkar_btn_Click(object sender, EventArgs e)
        {
            sqlconnect sqlconnect = new sqlconnect();
            sqlconnect.ConnectionOpen();
            for (int i = kategorilerListView.Items.Count - 1; i >= 0; i--)
            {
                if (kategorilerListView.Items[i].Selected)
                {
                    try {

                    SqlCommand command = new SqlCommand($"DELETE FROM Kategoriler WHERE KategoriID = {kategorilerListView.Items[i].Text}", sqlconnect.Baglanti);
                        int affectedRows = command.ExecuteNonQuery();

                        kategorilerListView.Items.RemoveAt(i);
                    }
                    catch{
                        MessageBox.Show("bruh moment code 3: delete unsuccessfull");
                    }

                }
            }

        }
    }
}
