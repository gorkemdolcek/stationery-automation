namespace BoldPencils
{
    partial class Depo
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
            depo_panel = new System.Windows.Forms.Panel();
            button1 = new Button();
            depotransfer_btn = new Button();
            depodetay_btn = new Button();
            depo_btn = new Button();
            depopaneli_label = new Label();
            arama_label = new Label();
            depo_search_textBox = new TextBox();
            depo_ListView = new ListView();
            DepoIDColumn = new ColumnHeader();
            DepoDetayID = new ColumnHeader();
            UrunID = new ColumnHeader();
            UrunAdet = new ColumnHeader();
            depodetay_listView = new ListView();
            ID = new ColumnHeader();
            Şehir = new ColumnHeader();
            Bölge = new ColumnHeader();
            PersonelSayisi = new ColumnHeader();
            depotransfer_listView = new ListView();
            TransferID = new ColumnHeader();
            urunIDD = new ColumnHeader();
            KaynakDepoID = new ColumnHeader();
            HedefDepoID = new ColumnHeader();
            TransferMiktar = new ColumnHeader();
            TransferTarihi = new ColumnHeader();
            depo_panel.SuspendLayout();
            SuspendLayout();
            // 
            // depo_panel
            // 
            depo_panel.BackColor = Color.FromArgb(27, 66, 66);
            depo_panel.Controls.Add(button1);
            depo_panel.Controls.Add(depotransfer_btn);
            depo_panel.Controls.Add(depodetay_btn);
            depo_panel.Controls.Add(depo_btn);
            depo_panel.Controls.Add(depopaneli_label);
            depo_panel.Controls.Add(arama_label);
            depo_panel.Controls.Add(depo_search_textBox);
            depo_panel.Controls.Add(depo_ListView);
            depo_panel.Controls.Add(depodetay_listView);
            depo_panel.Controls.Add(depotransfer_listView);
            depo_panel.Dock = DockStyle.Fill;
            depo_panel.Location = new Point(0, 0);
            depo_panel.Name = "depo_panel";
            depo_panel.Size = new Size(797, 643);
            depo_panel.TabIndex = 10;
            depo_panel.Paint += depo_panel_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(61, 557);
            button1.Name = "button1";
            button1.Size = new Size(246, 30);
            button1.TabIndex = 18;
            button1.Text = "Arama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // depotransfer_btn
            // 
            depotransfer_btn.Location = new Point(558, 429);
            depotransfer_btn.Name = "depotransfer_btn";
            depotransfer_btn.Size = new Size(182, 27);
            depotransfer_btn.TabIndex = 17;
            depotransfer_btn.Text = "Depo Transfer";
            depotransfer_btn.UseVisualStyleBackColor = true;
            depotransfer_btn.Click += depotransfer_btn_Click;
            // 
            // depodetay_btn
            // 
            depodetay_btn.Location = new Point(308, 429);
            depodetay_btn.Name = "depodetay_btn";
            depodetay_btn.Size = new Size(178, 27);
            depodetay_btn.TabIndex = 16;
            depodetay_btn.Text = "Depo Detay";
            depodetay_btn.UseVisualStyleBackColor = true;
            depodetay_btn.Click += depodetay_btn_Click;
            // 
            // depo_btn
            // 
            depo_btn.Location = new Point(61, 429);
            depo_btn.Name = "depo_btn";
            depo_btn.Size = new Size(177, 27);
            depo_btn.TabIndex = 13;
            depo_btn.Text = "Depo ";
            depo_btn.UseVisualStyleBackColor = true;
            depo_btn.Click += depo_btn_Click;
            // 
            // depopaneli_label
            // 
            depopaneli_label.AutoSize = true;
            depopaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            depopaneli_label.ForeColor = Color.White;
            depopaneli_label.Location = new Point(61, 42);
            depopaneli_label.Name = "depopaneli_label";
            depopaneli_label.Size = new Size(83, 17);
            depopaneli_label.TabIndex = 9;
            depopaneli_label.Text = "Depo Paneli";
            // 
            // arama_label
            // 
            arama_label.AutoSize = true;
            arama_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            arama_label.ForeColor = Color.White;
            arama_label.Location = new Point(61, 499);
            arama_label.Name = "arama_label";
            arama_label.Size = new Size(48, 17);
            arama_label.TabIndex = 5;
            arama_label.Text = "Arama";
            // 
            // depo_search_textBox
            // 
            depo_search_textBox.Location = new Point(61, 528);
            depo_search_textBox.Name = "depo_search_textBox";
            depo_search_textBox.Size = new Size(246, 23);
            depo_search_textBox.TabIndex = 1;
            // 
            // depo_ListView
            // 
            depo_ListView.Alignment = ListViewAlignment.SnapToGrid;
            depo_ListView.AutoArrange = false;
            depo_ListView.Columns.AddRange(new ColumnHeader[] { DepoIDColumn, DepoDetayID, UrunID, UrunAdet });
            depo_ListView.FullRowSelect = true;
            depo_ListView.Location = new Point(52, 62);
            depo_ListView.Name = "depo_ListView";
            depo_ListView.Size = new Size(688, 361);
            depo_ListView.TabIndex = 12;
            depo_ListView.UseCompatibleStateImageBehavior = false;
            depo_ListView.View = View.Details;
            depo_ListView.SelectedIndexChanged += depo_ListView1_SelectedIndexChanged;
            // 
            // DepoIDColumn
            // 
            DepoIDColumn.Text = "DepoID";
            DepoIDColumn.Width = 50;
            // 
            // DepoDetayID
            // 
            DepoDetayID.Text = "DepoDetayID";
            // 
            // UrunID
            // 
            UrunID.Text = "UrunID";
            // 
            // UrunAdet
            // 
            UrunAdet.Text = "UrunAdet";
            // 
            // depodetay_listView
            // 
            depodetay_listView.Columns.AddRange(new ColumnHeader[] { ID, Şehir, Bölge, PersonelSayisi });
            depodetay_listView.Location = new Point(52, 62);
            depodetay_listView.Name = "depodetay_listView";
            depodetay_listView.Size = new Size(688, 361);
            depodetay_listView.TabIndex = 14;
            depodetay_listView.UseCompatibleStateImageBehavior = false;
            depodetay_listView.View = View.Details;
            depodetay_listView.Visible = false;
            depodetay_listView.SelectedIndexChanged += depodetay_listView_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Şehir
            // 
            Şehir.Text = "Şehir";
            // 
            // Bölge
            // 
            Bölge.Text = "Bölge";
            // 
            // PersonelSayisi
            // 
            PersonelSayisi.Text = "Personel Sayısı";
            // 
            // depotransfer_listView
            // 
            depotransfer_listView.Columns.AddRange(new ColumnHeader[] { TransferID, urunIDD, KaynakDepoID, HedefDepoID, TransferMiktar, TransferTarihi });
            depotransfer_listView.Location = new Point(52, 62);
            depotransfer_listView.Name = "depotransfer_listView";
            depotransfer_listView.Size = new Size(688, 361);
            depotransfer_listView.TabIndex = 15;
            depotransfer_listView.UseCompatibleStateImageBehavior = false;
            depotransfer_listView.View = View.Details;
            depotransfer_listView.Visible = false;
            depotransfer_listView.SelectedIndexChanged += depotransfer_listView_SelectedIndexChanged;
            // 
            // TransferID
            // 
            TransferID.Text = "TransferID";
            // 
            // urunIDD
            // 
            urunIDD.Text = "UrunID";
            // 
            // KaynakDepoID
            // 
            KaynakDepoID.Text = "KaynakDepoID";
            // 
            // HedefDepoID
            // 
            HedefDepoID.Text = "HedefDepoID";
            // 
            // TransferMiktar
            // 
            TransferMiktar.Text = "TransferMiktar";
            // 
            // TransferTarihi
            // 
            TransferTarihi.Text = "TransferTarihi";
            // 
            // Depo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(797, 643);
            Controls.Add(depo_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Depo";
            Text = "Depo";
            depo_panel.ResumeLayout(false);
            depo_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel depo_panel;
        private Label depopaneli_label;
        private Label arama_label;
        private TextBox depo_search_textBox;
        private ListView depo_ListView;
        private ColumnHeader MusteriID;
        private ColumnHeader DepoIDColumn;
        private ColumnHeader DepoDetayID;
        private ColumnHeader UrunID;
        private ColumnHeader UrunAdet;
        private ListView depodetay_listView;
        private Button depo_btn;
        private Button depotransfer_btn;
        private Button depodetay_btn;
        private ListView depotransfer_listView;
        private ColumnHeader ID;
        private ColumnHeader Şehir;
        private ColumnHeader Bölge;
        private ColumnHeader PersonelSayisi;
        private ColumnHeader TransferID;
        private ColumnHeader urunIDD;
        private ColumnHeader KaynakDepoID;
        private ColumnHeader HedefDepoID;
        private ColumnHeader TransferMiktar;
        private ColumnHeader TransferTarihi;
        private Button button1;
    }
}