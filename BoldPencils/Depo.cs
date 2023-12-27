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
            /*
       sqlconnect sqlconnect = new sqlconnect();
       sqlconnect.ConnectionOpen();
       SqlCommand command = new SqlCommand("", sqlconnect.Baglanti);
       SqlDataReader reader = command.ExecuteReader();

       while (reader.Read())
           {
           ListViewItem listViewItem = new ListViewItem();
           listViewItem.Text = reader["DepoID"].ToString();
           listViewItem.SubItems.Add(reader["DepoDetayID"].ToString());
           listViewItem.SubItems.Add(reader["UrunID"].ToString());
           listViewItem.SubItems.Add(reader["UrunAdet"].ToString());

           depo_ListView1.Items.Add(listViewItem);
       }

       reader.Close();



       depo_ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
       depo_ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
       *
       */

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
        }

        private void depotransfer_btn_Click(object sender, EventArgs e)
        {
            depotransfer_listView.Visible = true;
            depodetay_listView.Visible = false;
            depo_ListView.Visible = false;
        }
    }
}
