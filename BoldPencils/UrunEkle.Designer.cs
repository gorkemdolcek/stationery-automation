namespace BoldPencils
{
    partial class UrunEkle
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
            siparisEkleButton = new Button();
            tedarikciid_sql = new TextBox();
            kategoriid_sql = new TextBox();
            stokdurumu_sql = new TextBox();
            fiyat_sql = new TextBox();
            urunAdi_sql = new TextBox();
            urunID_sql = new TextBox();
            SuspendLayout();
            // 
            // siparisEkleButton
            // 
            siparisEkleButton.Location = new Point(55, 215);
            siparisEkleButton.Name = "siparisEkleButton";
            siparisEkleButton.Size = new Size(394, 38);
            siparisEkleButton.TabIndex = 19;
            siparisEkleButton.Text = "Ekle";
            siparisEkleButton.UseVisualStyleBackColor = true;
            siparisEkleButton.Click += siparisEkleButton_Click;
            // 
            // tedarikciid_sql
            // 
            tedarikciid_sql.Location = new Point(55, 186);
            tedarikciid_sql.Name = "tedarikciid_sql";
            tedarikciid_sql.PlaceholderText = "Tedarikci ID";
            tedarikciid_sql.Size = new Size(394, 23);
            tedarikciid_sql.TabIndex = 15;
            // 
            // kategoriid_sql
            // 
            kategoriid_sql.Location = new Point(55, 157);
            kategoriid_sql.Name = "kategoriid_sql";
            kategoriid_sql.PlaceholderText = "Kategori ID";
            kategoriid_sql.Size = new Size(394, 23);
            kategoriid_sql.TabIndex = 14;
            // 
            // stokdurumu_sql
            // 
            stokdurumu_sql.Location = new Point(55, 128);
            stokdurumu_sql.Name = "stokdurumu_sql";
            stokdurumu_sql.PlaceholderText = "Stok Durumu";
            stokdurumu_sql.Size = new Size(394, 23);
            stokdurumu_sql.TabIndex = 13;
            // 
            // fiyat_sql
            // 
            fiyat_sql.Location = new Point(55, 99);
            fiyat_sql.Name = "fiyat_sql";
            fiyat_sql.PlaceholderText = "Fiyat";
            fiyat_sql.Size = new Size(394, 23);
            fiyat_sql.TabIndex = 12;
            // 
            // urunAdi_sql
            // 
            urunAdi_sql.Location = new Point(55, 70);
            urunAdi_sql.Name = "urunAdi_sql";
            urunAdi_sql.PlaceholderText = "UrunAdi";
            urunAdi_sql.Size = new Size(394, 23);
            urunAdi_sql.TabIndex = 11;
            // 
            // urunID_sql
            // 
            urunID_sql.Location = new Point(55, 41);
            urunID_sql.Name = "urunID_sql";
            urunID_sql.PlaceholderText = "UrunID";
            urunID_sql.Size = new Size(394, 23);
            urunID_sql.TabIndex = 10;
            // 
            // UrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(504, 292);
            Controls.Add(siparisEkleButton);
            Controls.Add(tedarikciid_sql);
            Controls.Add(kategoriid_sql);
            Controls.Add(stokdurumu_sql);
            Controls.Add(fiyat_sql);
            Controls.Add(urunAdi_sql);
            Controls.Add(urunID_sql);
            Name = "UrunEkle";
            Text = "UrunEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button siparisEkleButton;
        private TextBox tedarikciid_sql;
        private TextBox kategoriid_sql;
        private TextBox stokdurumu_sql;
        private TextBox fiyat_sql;
        private TextBox urunAdi_sql;
        private TextBox urunID_sql;
    }
}