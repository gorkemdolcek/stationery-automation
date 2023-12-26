namespace BoldPencils
{
    partial class SiparisEkle
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
            satisID_sql = new TextBox();
            satisTarihi_sql = new TextBox();
            sehir_sql = new TextBox();
            adres_sql = new TextBox();
            birimfiyat_sql = new TextBox();
            miktar_sql = new TextBox();
            urunid_sql = new TextBox();
            musteriid_sql = new TextBox();
            personelid_sql = new TextBox();
            siparisEkleButton = new Button();
            SuspendLayout();
            // 
            // satisID_sql
            // 
            satisID_sql.Location = new Point(57, 37);
            satisID_sql.Name = "satisID_sql";
            satisID_sql.PlaceholderText = "SatisID";
            satisID_sql.Size = new Size(394, 23);
            satisID_sql.TabIndex = 0;
            // 
            // satisTarihi_sql
            // 
            satisTarihi_sql.Location = new Point(57, 66);
            satisTarihi_sql.Name = "satisTarihi_sql";
            satisTarihi_sql.PlaceholderText = "Satis Tarihi (2023-01-01 13:50:00)";
            satisTarihi_sql.Size = new Size(394, 23);
            satisTarihi_sql.TabIndex = 1;
            // 
            // sehir_sql
            // 
            sehir_sql.Location = new Point(57, 124);
            sehir_sql.Name = "sehir_sql";
            sehir_sql.PlaceholderText = "Sehir";
            sehir_sql.Size = new Size(394, 23);
            sehir_sql.TabIndex = 3;
            // 
            // adres_sql
            // 
            adres_sql.Location = new Point(57, 95);
            adres_sql.Name = "adres_sql";
            adres_sql.PlaceholderText = "Adres";
            adres_sql.Size = new Size(394, 23);
            adres_sql.TabIndex = 2;
            // 
            // birimfiyat_sql
            // 
            birimfiyat_sql.Location = new Point(57, 153);
            birimfiyat_sql.Name = "birimfiyat_sql";
            birimfiyat_sql.PlaceholderText = "Birim Fiyat";
            birimfiyat_sql.Size = new Size(394, 23);
            birimfiyat_sql.TabIndex = 4;
            // 
            // miktar_sql
            // 
            miktar_sql.Location = new Point(57, 182);
            miktar_sql.Name = "miktar_sql";
            miktar_sql.PlaceholderText = "Miktar";
            miktar_sql.Size = new Size(394, 23);
            miktar_sql.TabIndex = 5;
            // 
            // urunid_sql
            // 
            urunid_sql.Location = new Point(57, 269);
            urunid_sql.Name = "urunid_sql";
            urunid_sql.PlaceholderText = "UrunID";
            urunid_sql.Size = new Size(394, 23);
            urunid_sql.TabIndex = 8;
            // 
            // musteriid_sql
            // 
            musteriid_sql.Location = new Point(57, 240);
            musteriid_sql.Name = "musteriid_sql";
            musteriid_sql.PlaceholderText = "MusteriID";
            musteriid_sql.Size = new Size(394, 23);
            musteriid_sql.TabIndex = 7;
            // 
            // personelid_sql
            // 
            personelid_sql.Location = new Point(57, 211);
            personelid_sql.Name = "personelid_sql";
            personelid_sql.PlaceholderText = "PersonelID";
            personelid_sql.Size = new Size(394, 23);
            personelid_sql.TabIndex = 6;
            // 
            // siparisEkleButton
            // 
            siparisEkleButton.Location = new Point(57, 298);
            siparisEkleButton.Name = "siparisEkleButton";
            siparisEkleButton.Size = new Size(394, 38);
            siparisEkleButton.TabIndex = 9;
            siparisEkleButton.Text = "Ekle";
            siparisEkleButton.UseVisualStyleBackColor = true;
            siparisEkleButton.Click += siparisEkleButton_Click;
            // 
            // SiparisEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(504, 380);
            Controls.Add(siparisEkleButton);
            Controls.Add(urunid_sql);
            Controls.Add(musteriid_sql);
            Controls.Add(personelid_sql);
            Controls.Add(miktar_sql);
            Controls.Add(birimfiyat_sql);
            Controls.Add(sehir_sql);
            Controls.Add(adres_sql);
            Controls.Add(satisTarihi_sql);
            Controls.Add(satisID_sql);
            Name = "SiparisEkle";
            Text = "SiparisEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox satisID_sql;
        private TextBox satisTarihi_sql;
        private TextBox sehir_sql;
        private TextBox adres_sql;
        private TextBox birimfiyat_sql;
        private TextBox miktar_sql;
        private TextBox urunid_sql;
        private TextBox musteriid_sql;
        private TextBox personelid_sql;
        private Button siparisEkleButton;
    }
}