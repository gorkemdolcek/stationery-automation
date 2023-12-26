namespace BoldPencils
{
    partial class Siparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            siparis_panel = new System.Windows.Forms.Panel();
            sipariscıkar_btn = new Button();
            siparisekle_btn = new Button();
            siparis_label = new Label();
            siparisler_listView = new ListView();
            SatisID = new ColumnHeader();
            SatisTarihi = new ColumnHeader();
            Adres = new ColumnHeader();
            Sehir = new ColumnHeader();
            BirimFiyat = new ColumnHeader();
            Miktar = new ColumnHeader();
            PersonelID = new ColumnHeader();
            MusteriID = new ColumnHeader();
            UrunId = new ColumnHeader();
            siparis_panel.SuspendLayout();
            SuspendLayout();
            // 
            // siparis_panel
            // 
            siparis_panel.Controls.Add(sipariscıkar_btn);
            siparis_panel.Controls.Add(siparisekle_btn);
            siparis_panel.Controls.Add(siparis_label);
            siparis_panel.Controls.Add(siparisler_listView);
            siparis_panel.Dock = DockStyle.Fill;
            siparis_panel.Location = new Point(0, 0);
            siparis_panel.Name = "siparis_panel";
            siparis_panel.Size = new Size(1007, 643);
            siparis_panel.TabIndex = 3;
            siparis_panel.Paint += siparis_panel_Paint;
            // 
            // sipariscıkar_btn
            // 
            sipariscıkar_btn.Location = new Point(233, 464);
            sipariscıkar_btn.Name = "sipariscıkar_btn";
            sipariscıkar_btn.Size = new Size(152, 56);
            sipariscıkar_btn.TabIndex = 6;
            sipariscıkar_btn.Text = "Sipariş Çıkar";
            sipariscıkar_btn.UseVisualStyleBackColor = true;
            sipariscıkar_btn.Click += sipariscıkar_btn_Click;
            // 
            // siparisekle_btn
            // 
            siparisekle_btn.Location = new Point(75, 464);
            siparisekle_btn.Name = "siparisekle_btn";
            siparisekle_btn.Size = new Size(152, 56);
            siparisekle_btn.TabIndex = 5;
            siparisekle_btn.Text = "Sipariş Ekle";
            siparisekle_btn.UseVisualStyleBackColor = true;
            siparisekle_btn.Click += siparisekle_btn_Click;
            // 
            // siparis_label
            // 
            siparis_label.AutoSize = true;
            siparis_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            siparis_label.ForeColor = Color.White;
            siparis_label.Location = new Point(12, 26);
            siparis_label.Name = "siparis_label";
            siparis_label.Size = new Size(120, 32);
            siparis_label.TabIndex = 1;
            siparis_label.Text = "Siparişler";
            // 
            // siparisler_listView
            // 
            siparisler_listView.Columns.AddRange(new ColumnHeader[] { SatisID, SatisTarihi, Adres, Sehir, BirimFiyat, Miktar, PersonelID, MusteriID, UrunId });
            siparisler_listView.Location = new Point(75, 97);
            siparisler_listView.Name = "siparisler_listView";
            siparisler_listView.Size = new Size(837, 361);
            siparisler_listView.TabIndex = 8;
            siparisler_listView.UseCompatibleStateImageBehavior = false;
            siparisler_listView.View = View.Details;
            // 
            // SatisID
            // 
            SatisID.Text = "SatisID";
            // 
            // SatisTarihi
            // 
            SatisTarihi.Text = "SatisTarihi";
            // 
            // Adres
            // 
            Adres.Text = "Adres";
            // 
            // Sehir
            // 
            Sehir.Text = "Sehir";
            // 
            // BirimFiyat
            // 
            BirimFiyat.Text = "BirimFiyat";
            // 
            // Miktar
            // 
            Miktar.Text = "Miktar";
            // 
            // PersonelID
            // 
            PersonelID.Text = "PersonelID";
            // 
            // MusteriID
            // 
            MusteriID.Text = "MusteriID";
            // 
            // UrunId
            // 
            UrunId.Text = "UrunId";
            // 
            // Siparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(1007, 643);
            Controls.Add(siparis_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Siparis";
            Text = "Siparis";
            siparis_panel.ResumeLayout(false);
            siparis_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel siparis_panel;
        private Label siparis_label;
        private Button siparisekle_btn;
        private Button sipariscıkar_btn;
        private ListView siparisler_listView;
        private ColumnHeader SatisID;
        private ColumnHeader SatisTarihi;
        private ColumnHeader Adres;
        private ColumnHeader Sehir;
        private ColumnHeader BirimFiyat;
        private ColumnHeader Miktar;
        private ColumnHeader PersonelID;
        private ColumnHeader MusteriID;
        private ColumnHeader UrunId;
    }
}