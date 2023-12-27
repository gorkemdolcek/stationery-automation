namespace BoldPencils
{
    partial class Personel
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
            satıs_panel = new System.Windows.Forms.Panel();
            textBox1 = new TextBox();
            azsirala = new Button();
            button1 = new Button();
            personelmaasdusur_btn = new Button();
            satıspaneli_label = new Label();
            arama_label = new Label();
            satıs_label = new Label();
            personel_search_textBox = new TextBox();
            zasirala = new Button();
            personelcıkar_btn = new Button();
            personelekle_btn = new Button();
            personel_listview1 = new ListView();
            ID = new ColumnHeader();
            Adi = new ColumnHeader();
            Soyadi = new ColumnHeader();
            Telefon = new ColumnHeader();
            Email = new ColumnHeader();
            Maaş = new ColumnHeader();
            Şehir = new ColumnHeader();
            Bölge = new ColumnHeader();
            satıs_panel.SuspendLayout();
            SuspendLayout();
            // 
            // satıs_panel
            // 
            satıs_panel.BackColor = Color.FromArgb(27, 66, 66);
            satıs_panel.Controls.Add(textBox1);
            satıs_panel.Controls.Add(azsirala);
            satıs_panel.Controls.Add(button1);
            satıs_panel.Controls.Add(personelmaasdusur_btn);
            satıs_panel.Controls.Add(satıspaneli_label);
            satıs_panel.Controls.Add(arama_label);
            satıs_panel.Controls.Add(satıs_label);
            satıs_panel.Controls.Add(personel_search_textBox);
            satıs_panel.Controls.Add(zasirala);
            satıs_panel.Controls.Add(personelcıkar_btn);
            satıs_panel.Controls.Add(personelekle_btn);
            satıs_panel.Controls.Add(personel_listview1);
            satıs_panel.Dock = DockStyle.Fill;
            satıs_panel.Location = new Point(0, 0);
            satıs_panel.Name = "satıs_panel";
            satıs_panel.Size = new Size(797, 643);
            satıs_panel.TabIndex = 10;
            satıs_panel.Paint += satıs_panel_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(418, 507);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Yeni Maaş Değeri";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 16;
            // 
            // azsirala
            // 
            azsirala.Location = new Point(99, 536);
            azsirala.Name = "azsirala";
            azsirala.Size = new Size(152, 45);
            azsirala.TabIndex = 15;
            azsirala.Text = "A-Z Sırala";
            azsirala.UseVisualStyleBackColor = true;
            azsirala.Click += azsirala_Click;
            // 
            // button1
            // 
            button1.Location = new Point(99, 485);
            button1.Name = "button1";
            button1.Size = new Size(152, 45);
            button1.TabIndex = 14;
            button1.Text = "Verileri Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // personelmaasdusur_btn
            // 
            personelmaasdusur_btn.Location = new Point(490, 536);
            personelmaasdusur_btn.Name = "personelmaasdusur_btn";
            personelmaasdusur_btn.Size = new Size(132, 39);
            personelmaasdusur_btn.TabIndex = 11;
            personelmaasdusur_btn.Text = "Personel Maaş Güncelle";
            personelmaasdusur_btn.UseVisualStyleBackColor = true;
            personelmaasdusur_btn.Click += personelmaasdusur_btn_Click;
            // 
            // satıspaneli_label
            // 
            satıspaneli_label.AutoSize = true;
            satıspaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıspaneli_label.ForeColor = Color.White;
            satıspaneli_label.Location = new Point(61, 42);
            satıspaneli_label.Name = "satıspaneli_label";
            satıspaneli_label.Size = new Size(103, 17);
            satıspaneli_label.TabIndex = 9;
            satıspaneli_label.Text = "Personel Paneli";
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
            // satıs_label
            // 
            satıs_label.AutoSize = true;
            satıs_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıs_label.ForeColor = Color.White;
            satıs_label.Location = new Point(418, 435);
            satıs_label.Name = "satıs_label";
            satıs_label.Size = new Size(57, 17);
            satıs_label.TabIndex = 8;
            satıs_label.Text = "İşlemler";
            // 
            // personel_search_textBox
            // 
            personel_search_textBox.Location = new Point(61, 456);
            personel_search_textBox.Name = "personel_search_textBox";
            personel_search_textBox.Size = new Size(246, 23);
            personel_search_textBox.TabIndex = 1;
            // 
            // zasirala
            // 
            zasirala.Location = new Point(99, 587);
            zasirala.Name = "zasirala";
            zasirala.Size = new Size(152, 45);
            zasirala.TabIndex = 4;
            zasirala.Text = "Z-A Sırala";
            zasirala.UseVisualStyleBackColor = true;
            zasirala.Click += zasirala_Click;
            // 
            // personelcıkar_btn
            // 
            personelcıkar_btn.Location = new Point(556, 456);
            personelcıkar_btn.Name = "personelcıkar_btn";
            personelcıkar_btn.Size = new Size(132, 39);
            personelcıkar_btn.TabIndex = 6;
            personelcıkar_btn.Text = "Personel Çıkar";
            personelcıkar_btn.UseVisualStyleBackColor = true;
            personelcıkar_btn.Click += personelcıkar_btn_Click;
            // 
            // personelekle_btn
            // 
            personelekle_btn.Location = new Point(418, 456);
            personelekle_btn.Name = "personelekle_btn";
            personelekle_btn.Size = new Size(132, 39);
            personelekle_btn.TabIndex = 7;
            personelekle_btn.Text = "Personel Ekle";
            personelekle_btn.UseVisualStyleBackColor = true;
            personelekle_btn.Click += personelekle_btn_Click;
            // 
            // personel_listview1
            // 
            personel_listview1.Columns.AddRange(new ColumnHeader[] { ID, Adi, Soyadi, Telefon, Email, Maaş, Şehir, Bölge });
            personel_listview1.Location = new Point(61, 62);
            personel_listview1.Name = "personel_listview1";
            personel_listview1.Size = new Size(679, 361);
            personel_listview1.TabIndex = 13;
            personel_listview1.UseCompatibleStateImageBehavior = false;
            personel_listview1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Adi
            // 
            Adi.Text = "Adi";
            // 
            // Soyadi
            // 
            Soyadi.Text = "Soyadi";
            // 
            // Telefon
            // 
            Telefon.Text = "Telefon";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // Maaş
            // 
            Maaş.Text = "Maaş";
            // 
            // Şehir
            // 
            Şehir.Text = "Şehir";
            // 
            // Bölge
            // 
            Bölge.Text = "Bölge";
            // 
            // Personel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(797, 643);
            Controls.Add(satıs_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Personel";
            Text = "Personel";
            satıs_panel.ResumeLayout(false);
            satıs_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel satıs_panel;
        private Label satıspaneli_label;
        private ListBox satıs_listBox;
        private Label arama_label;
        private Label satıs_label;
        private TextBox personel_search_textBox;
        private RadioButton azdancok_radiobtn;
        private Button zasirala;
        private RadioButton coktanaz_radiobtn;
        private Button personelcıkar_btn;
        private Button personelekle_btn;
        private Button personelmaasdusur_btn;
        private ListView personel_listview1;
        private ColumnHeader ID;
        private ColumnHeader Adi;
        private ColumnHeader Soyadi;
        private ColumnHeader Telefon;
        private ColumnHeader Email;
        private ColumnHeader Maaş;
        private ColumnHeader Şehir;
        private ColumnHeader Bölge;
        private Button azsirala;
        private Button button1;
        private TextBox textBox1;
    }
}