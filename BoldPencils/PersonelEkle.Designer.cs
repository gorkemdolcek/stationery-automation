namespace BoldPencils
{
    partial class PersonelEkle
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
            personelEkleButton = new Button();
            maas_sql = new TextBox();
            email_sql = new TextBox();
            telefon_sql = new TextBox();
            soyadi_sql = new TextBox();
            adi_sql = new TextBox();
            personelID_sql = new TextBox();
            bolge_sql = new TextBox();
            sehir_sql = new TextBox();
            SuspendLayout();
            // 
            // personelEkleButton
            // 
            personelEkleButton.Location = new Point(55, 272);
            personelEkleButton.Name = "personelEkleButton";
            personelEkleButton.Size = new Size(394, 38);
            personelEkleButton.TabIndex = 26;
            personelEkleButton.Text = "Ekle";
            personelEkleButton.UseVisualStyleBackColor = true;
            personelEkleButton.Click += siparisEkleButton_Click;
            // 
            // maas_sql
            // 
            maas_sql.Location = new Point(55, 185);
            maas_sql.Name = "maas_sql";
            maas_sql.PlaceholderText = "Maaş";
            maas_sql.Size = new Size(394, 23);
            maas_sql.TabIndex = 25;
            // 
            // email_sql
            // 
            email_sql.Location = new Point(55, 156);
            email_sql.Name = "email_sql";
            email_sql.PlaceholderText = "Email";
            email_sql.Size = new Size(394, 23);
            email_sql.TabIndex = 24;
            // 
            // telefon_sql
            // 
            telefon_sql.Location = new Point(55, 127);
            telefon_sql.Name = "telefon_sql";
            telefon_sql.PlaceholderText = "Telefon";
            telefon_sql.Size = new Size(394, 23);
            telefon_sql.TabIndex = 23;
            // 
            // soyadi_sql
            // 
            soyadi_sql.Location = new Point(55, 98);
            soyadi_sql.Name = "soyadi_sql";
            soyadi_sql.PlaceholderText = "Soyadi";
            soyadi_sql.Size = new Size(394, 23);
            soyadi_sql.TabIndex = 22;
            // 
            // adi_sql
            // 
            adi_sql.Location = new Point(55, 69);
            adi_sql.Name = "adi_sql";
            adi_sql.PlaceholderText = "Adi";
            adi_sql.Size = new Size(394, 23);
            adi_sql.TabIndex = 21;
            // 
            // personelID_sql
            // 
            personelID_sql.Location = new Point(55, 40);
            personelID_sql.Name = "personelID_sql";
            personelID_sql.PlaceholderText = "PersonelID";
            personelID_sql.Size = new Size(394, 23);
            personelID_sql.TabIndex = 20;
            // 
            // bolge_sql
            // 
            bolge_sql.Location = new Point(55, 243);
            bolge_sql.Name = "bolge_sql";
            bolge_sql.PlaceholderText = "bolge_sql";
            bolge_sql.Size = new Size(394, 23);
            bolge_sql.TabIndex = 28;
            // 
            // sehir_sql
            // 
            sehir_sql.Location = new Point(55, 214);
            sehir_sql.Name = "sehir_sql";
            sehir_sql.PlaceholderText = "Şehir";
            sehir_sql.Size = new Size(394, 23);
            sehir_sql.TabIndex = 27;
            // 
            // PersonelEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(504, 337);
            Controls.Add(bolge_sql);
            Controls.Add(sehir_sql);
            Controls.Add(personelEkleButton);
            Controls.Add(maas_sql);
            Controls.Add(email_sql);
            Controls.Add(telefon_sql);
            Controls.Add(soyadi_sql);
            Controls.Add(adi_sql);
            Controls.Add(personelID_sql);
            Name = "PersonelEkle";
            Text = "PersonelEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button personelEkleButton;
        private TextBox maas_sql;
        private TextBox email_sql;
        private TextBox telefon_sql;
        private TextBox soyadi_sql;
        private TextBox adi_sql;
        private TextBox personelID_sql;
        private TextBox bolge_sql;
        private TextBox sehir_sql;
    }
}