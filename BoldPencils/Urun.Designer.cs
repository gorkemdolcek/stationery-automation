namespace BoldPencils
{
    partial class Urun
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
            urun_panel = new System.Windows.Forms.Panel();
            zasirala = new Button();
            azsirala = new Button();
            button2 = new Button();
            button1 = new Button();
            eklecıkar_label = new Label();
            yıllıkazurun_btn = new Button();
            aylıkazurun_btn = new Button();
            urunpaneli_label = new Label();
            arama_label = new Label();
            urun_label = new Label();
            urun_search_textBox = new TextBox();
            verileriver_btn = new Button();
            aylıkcokurun_btn = new Button();
            yıllıkcokurun_btn = new Button();
            urunlistview = new ListView();
            ID = new ColumnHeader();
            UrunAdi = new ColumnHeader();
            Fiyat = new ColumnHeader();
            StokDurumu = new ColumnHeader();
            KategoriID = new ColumnHeader();
            TedarikciID = new ColumnHeader();
            urun_panel.SuspendLayout();
            SuspendLayout();
            // 
            // urun_panel
            // 
            urun_panel.BackColor = Color.FromArgb(27, 66, 66);
            urun_panel.Controls.Add(zasirala);
            urun_panel.Controls.Add(azsirala);
            urun_panel.Controls.Add(button2);
            urun_panel.Controls.Add(button1);
            urun_panel.Controls.Add(eklecıkar_label);
            urun_panel.Controls.Add(yıllıkazurun_btn);
            urun_panel.Controls.Add(aylıkazurun_btn);
            urun_panel.Controls.Add(urunpaneli_label);
            urun_panel.Controls.Add(arama_label);
            urun_panel.Controls.Add(urun_label);
            urun_panel.Controls.Add(urun_search_textBox);
            urun_panel.Controls.Add(verileriver_btn);
            urun_panel.Controls.Add(aylıkcokurun_btn);
            urun_panel.Controls.Add(yıllıkcokurun_btn);
            urun_panel.Controls.Add(urunlistview);
            urun_panel.Dock = DockStyle.Fill;
            urun_panel.Location = new Point(0, 0);
            urun_panel.Name = "urun_panel";
            urun_panel.Size = new Size(813, 682);
            urun_panel.TabIndex = 10;
            urun_panel.Paint += urun_panel_Paint;
            // 
            // zasirala
            // 
            zasirala.Location = new Point(99, 587);
            zasirala.Name = "zasirala";
            zasirala.Size = new Size(152, 45);
            zasirala.TabIndex = 18;
            zasirala.Text = "Z-A Sırala";
            zasirala.UseVisualStyleBackColor = true;
            zasirala.Click += zasirala_Click;
            // 
            // azsirala
            // 
            azsirala.Location = new Point(99, 536);
            azsirala.Name = "azsirala";
            azsirala.Size = new Size(152, 45);
            azsirala.TabIndex = 17;
            azsirala.Text = "A-Z Sırala";
            azsirala.UseVisualStyleBackColor = true;
            azsirala.Click += azsirala_Click;
            // 
            // button2
            // 
            button2.Location = new Point(618, 456);
            button2.Name = "button2";
            button2.Size = new Size(108, 39);
            button2.TabIndex = 14;
            button2.Text = "Ürün Çıkar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(504, 456);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 13;
            button1.Text = "Ürün Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eklecıkar_label
            // 
            eklecıkar_label.AutoSize = true;
            eklecıkar_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            eklecıkar_label.ForeColor = Color.White;
            eklecıkar_label.Location = new Point(504, 435);
            eklecıkar_label.Name = "eklecıkar_label";
            eklecıkar_label.Size = new Size(70, 17);
            eklecıkar_label.TabIndex = 12;
            eklecıkar_label.Text = "Ekle/Çıkar";
            // 
            // yıllıkazurun_btn
            // 
            yıllıkazurun_btn.Location = new Point(329, 545);
            yıllıkazurun_btn.Name = "yıllıkazurun_btn";
            yıllıkazurun_btn.Size = new Size(138, 39);
            yıllıkazurun_btn.TabIndex = 11;
            yıllıkazurun_btn.Text = "Bu Yıl En AZ Satılan Ürünler";
            yıllıkazurun_btn.UseVisualStyleBackColor = true;
            yıllıkazurun_btn.Click += yıllıkazurun_btn_Click;
            // 
            // aylıkazurun_btn
            // 
            aylıkazurun_btn.Location = new Point(329, 590);
            aylıkazurun_btn.Name = "aylıkazurun_btn";
            aylıkazurun_btn.Size = new Size(138, 39);
            aylıkazurun_btn.TabIndex = 10;
            aylıkazurun_btn.Text = "Bu Ay En AZ Satılan Ürünler";
            aylıkazurun_btn.UseVisualStyleBackColor = true;
            aylıkazurun_btn.Click += aylıkazurun_btn_Click;
            // 
            // urunpaneli_label
            // 
            urunpaneli_label.AutoSize = true;
            urunpaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunpaneli_label.ForeColor = Color.White;
            urunpaneli_label.Location = new Point(61, 42);
            urunpaneli_label.Name = "urunpaneli_label";
            urunpaneli_label.Size = new Size(80, 17);
            urunpaneli_label.TabIndex = 9;
            urunpaneli_label.Text = "Ürün Paneli";
            // 
            // arama_label
            // 
            arama_label.AutoSize = true;
            arama_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            arama_label.ForeColor = Color.White;
            arama_label.Location = new Point(61, 435);
            arama_label.Name = "arama_label";
            arama_label.Size = new Size(48, 17);
            arama_label.TabIndex = 5;
            arama_label.Text = "Arama";
            // 
            // urun_label
            // 
            urun_label.AutoSize = true;
            urun_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urun_label.ForeColor = Color.White;
            urun_label.Location = new Point(329, 435);
            urun_label.Name = "urun_label";
            urun_label.Size = new Size(57, 17);
            urun_label.TabIndex = 8;
            urun_label.Text = "İşlemler";
            // 
            // urun_search_textBox
            // 
            urun_search_textBox.Location = new Point(61, 456);
            urun_search_textBox.Name = "urun_search_textBox";
            urun_search_textBox.Size = new Size(246, 23);
            urun_search_textBox.TabIndex = 1;
            // 
            // verileriver_btn
            // 
            verileriver_btn.Location = new Point(99, 485);
            verileriver_btn.Name = "verileriver_btn";
            verileriver_btn.Size = new Size(152, 45);
            verileriver_btn.TabIndex = 4;
            verileriver_btn.Text = "Verileri Ver";
            verileriver_btn.UseVisualStyleBackColor = true;
            verileriver_btn.Click += verileriver_btn_Click;
            // 
            // aylıkcokurun_btn
            // 
            aylıkcokurun_btn.Location = new Point(329, 500);
            aylıkcokurun_btn.Name = "aylıkcokurun_btn";
            aylıkcokurun_btn.Size = new Size(138, 39);
            aylıkcokurun_btn.TabIndex = 6;
            aylıkcokurun_btn.Text = "Bu Ay En ÇOK Satılan Ürünler";
            aylıkcokurun_btn.UseVisualStyleBackColor = true;
            aylıkcokurun_btn.Click += aylıkcokurun_btn_Click;
            // 
            // yıllıkcokurun_btn
            // 
            yıllıkcokurun_btn.Location = new Point(329, 455);
            yıllıkcokurun_btn.Name = "yıllıkcokurun_btn";
            yıllıkcokurun_btn.Size = new Size(138, 39);
            yıllıkcokurun_btn.TabIndex = 7;
            yıllıkcokurun_btn.Text = "Bu Yıl En ÇOK Satılan Ürünler";
            yıllıkcokurun_btn.UseVisualStyleBackColor = true;
            yıllıkcokurun_btn.Click += yıllıkcokurun_btn_Click;
            // 
            // urunlistview
            // 
            urunlistview.Columns.AddRange(new ColumnHeader[] { ID, UrunAdi, Fiyat, StokDurumu, KategoriID, TedarikciID });
            urunlistview.Location = new Point(61, 62);
            urunlistview.Name = "urunlistview";
            urunlistview.Size = new Size(679, 361);
            urunlistview.TabIndex = 16;
            urunlistview.UseCompatibleStateImageBehavior = false;
            urunlistview.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // UrunAdi
            // 
            UrunAdi.Text = "UrunAdi";
            // 
            // Fiyat
            // 
            Fiyat.Text = "Fiyat";
            // 
            // StokDurumu
            // 
            StokDurumu.Text = "StokDurumu";
            // 
            // KategoriID
            // 
            KategoriID.Text = "KategoriID";
            // 
            // TedarikciID
            // 
            TedarikciID.Text = "TedarikciID";
            // 
            // Urun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(813, 682);
            Controls.Add(urun_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Urun";
            Text = "Urun";
            urun_panel.ResumeLayout(false);
            urun_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel urun_panel;
        private Label urunpaneli_label;
        private Label arama_label;
        private Label urun_label;
        private TextBox urun_search_textBox;
        private Button verileriver_btn;
        private Button aylıkcokurun_btn;
        private Button yıllıkcokurun_btn;
        private Button yıllıkazurun_btn;
        private Button aylıkazurun_btn;
        private Button button2;
        private Button button1;
        private Label eklecıkar_label;
        private ListView urunlistview;
        private ColumnHeader ID;
        private ColumnHeader UrunAdi;
        private ColumnHeader Fiyat;
        private ColumnHeader StokDurumu;
        private ColumnHeader KategoriID;
        private ColumnHeader TedarikciID;
        private Button zasirala;
        private Button azsirala;
    }
}