namespace BoldPencils
{
    partial class Musteri
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
            arama_label = new Label();
            musteri_search_textBox = new TextBox();
            verileriver_btn = new Button();
            musteri_label = new Label();
            musteri_panel = new System.Windows.Forms.Panel();
            zasirala = new Button();
            musteri_listView = new ListView();
            MusteriID = new ColumnHeader();
            Adi = new ColumnHeader();
            Soyadi = new ColumnHeader();
            Sehir = new ColumnHeader();
            Bolge = new ColumnHeader();
            Email = new ColumnHeader();
            Telefon = new ColumnHeader();
            musteripaneli_label = new Label();
            azsirala = new Button();
            musteri_panel.SuspendLayout();
            SuspendLayout();
            // 
            // arama_label
            // 
            arama_label.AutoSize = true;
            arama_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            arama_label.ForeColor = Color.White;
            arama_label.Location = new Point(61, 435);
            arama_label.Name = "arama_label";
            arama_label.Size = new Size(48, 17);
            arama_label.TabIndex = 6;
            arama_label.Text = "Arama";
            // 
            // musteri_search_textBox
            // 
            musteri_search_textBox.Location = new Point(61, 455);
            musteri_search_textBox.Name = "musteri_search_textBox";
            musteri_search_textBox.Size = new Size(246, 23);
            musteri_search_textBox.TabIndex = 7;
            // 
            // verileriver_btn
            // 
            verileriver_btn.Location = new Point(110, 484);
            verileriver_btn.Name = "verileriver_btn";
            verileriver_btn.Size = new Size(152, 45);
            verileriver_btn.TabIndex = 10;
            verileriver_btn.Text = "Verileri Ver";
            verileriver_btn.UseVisualStyleBackColor = true;
            verileriver_btn.Click += verileriver_btn_Click;
            // 
            // musteri_label
            // 
            musteri_label.AutoSize = true;
            musteri_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            musteri_label.ForeColor = Color.White;
            musteri_label.Location = new Point(418, 435);
            musteri_label.Name = "musteri_label";
            musteri_label.Size = new Size(57, 17);
            musteri_label.TabIndex = 11;
            musteri_label.Text = "İşlemler";
            // 
            // musteri_panel
            // 
            musteri_panel.BackColor = Color.FromArgb(27, 66, 66);
            musteri_panel.Controls.Add(zasirala);
            musteri_panel.Controls.Add(musteri_listView);
            musteri_panel.Controls.Add(musteripaneli_label);
            musteri_panel.Controls.Add(azsirala);
            musteri_panel.Controls.Add(verileriver_btn);
            musteri_panel.Controls.Add(arama_label);
            musteri_panel.Controls.Add(musteri_search_textBox);
            musteri_panel.Controls.Add(musteri_label);
            musteri_panel.Dock = DockStyle.Fill;
            musteri_panel.Location = new Point(0, 0);
            musteri_panel.Name = "musteri_panel";
            musteri_panel.Size = new Size(813, 682);
            musteri_panel.TabIndex = 12;
            musteri_panel.Paint += musteri_panel_Paint;
            // 
            // zasirala
            // 
            zasirala.Location = new Point(418, 500);
            zasirala.Name = "zasirala";
            zasirala.Size = new Size(132, 39);
            zasirala.TabIndex = 16;
            zasirala.Text = "Z-A Sırala";
            zasirala.UseVisualStyleBackColor = true;
            zasirala.Click += zasirala_Click;
            // 
            // musteri_listView
            // 
            musteri_listView.Columns.AddRange(new ColumnHeader[] { MusteriID, Adi, Soyadi, Sehir, Bolge, Email, Telefon });
            musteri_listView.Location = new Point(61, 62);
            musteri_listView.Name = "musteri_listView";
            musteri_listView.Size = new Size(679, 361);
            musteri_listView.TabIndex = 15;
            musteri_listView.UseCompatibleStateImageBehavior = false;
            musteri_listView.View = View.Details;
            // 
            // MusteriID
            // 
            MusteriID.Text = "MusteriID";
            // 
            // Adi
            // 
            Adi.Text = "Adi";
            // 
            // Soyadi
            // 
            Soyadi.Text = "Soyadi";
            // 
            // Sehir
            // 
            Sehir.Text = "Sehir";
            // 
            // Bolge
            // 
            Bolge.Text = "Bolge";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // Telefon
            // 
            Telefon.Text = "Telefon";
            // 
            // musteripaneli_label
            // 
            musteripaneli_label.AutoSize = true;
            musteripaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            musteripaneli_label.ForeColor = Color.White;
            musteripaneli_label.Location = new Point(61, 42);
            musteripaneli_label.Name = "musteripaneli_label";
            musteripaneli_label.Size = new Size(97, 17);
            musteripaneli_label.TabIndex = 14;
            musteripaneli_label.Text = "Müşteri Paneli";
            // 
            // azsirala
            // 
            azsirala.Location = new Point(418, 455);
            azsirala.Name = "azsirala";
            azsirala.Size = new Size(132, 39);
            azsirala.TabIndex = 13;
            azsirala.Text = "A-Z Sırala";
            azsirala.UseVisualStyleBackColor = true;
            azsirala.Click += azsirala_Click;
            // 
            // Musteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(813, 682);
            Controls.Add(musteri_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Musteri";
            Text = "Musteri";
            musteri_panel.ResumeLayout(false);
            musteri_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label arama_label;
        private TextBox musteri_search_textBox;
        private RadioButton azdancok_radiobtn;
        private RadioButton coktanaz_radiobtn;
        private Button verileriver_btn;
        private Label musteri_label;
        private System.Windows.Forms.Panel musteri_panel;
        private Button aylıkmusteri_btn;
        private Button azsirala;
        private Label musteripaneli_label;
        private ListView musteri_listView;
        private ColumnHeader MusteriID;
        private ColumnHeader Adi;
        private ColumnHeader Soyadi;
        private ColumnHeader Sehir;
        private ColumnHeader Bolge;
        private ColumnHeader Email;
        private ColumnHeader Telefon;
        private Button zasirala;
    }
}