namespace BoldPencils
{
    partial class AnasayfaPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaPage));
            urunislemleri_label = new Label();
            urunler_btn = new Button();
            personel_btn = new Button();
            depo_btn = new Button();
            magazaislemleri_btn = new Label();
            musteriislemleri_btn = new Label();
            musteri_btn = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            anasayfa_main_panel = new System.Windows.Forms.Panel();
            anasayfa_side_panel = new System.Windows.Forms.Panel();
            label6 = new Label();
            anasayfa_main_panel.SuspendLayout();
            anasayfa_side_panel.SuspendLayout();
            SuspendLayout();
            // 
            // urunislemleri_label
            // 
            urunislemleri_label.AutoSize = true;
            urunislemleri_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunislemleri_label.ForeColor = Color.White;
            urunislemleri_label.Location = new Point(3, 167);
            urunislemleri_label.Name = "urunislemleri_label";
            urunislemleri_label.Size = new Size(151, 30);
            urunislemleri_label.TabIndex = 0;
            urunislemleri_label.Text = "Ürün İşlemleri";
            // 
            // urunler_btn
            // 
            urunler_btn.FlatStyle = FlatStyle.Popup;
            urunler_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunler_btn.ForeColor = Color.White;
            urunler_btn.Image = Properties.Resources.product;
            urunler_btn.ImageAlign = ContentAlignment.MiddleLeft;
            urunler_btn.Location = new Point(12, 200);
            urunler_btn.Name = "urunler_btn";
            urunler_btn.Size = new Size(168, 48);
            urunler_btn.TabIndex = 1;
            urunler_btn.Text = "Ürünler";
            urunler_btn.UseVisualStyleBackColor = true;
            urunler_btn.Click += urunler_btn_Click;
            // 
            // personel_btn
            // 
            personel_btn.FlatStyle = FlatStyle.Popup;
            personel_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            personel_btn.ForeColor = Color.White;
            personel_btn.Image = Properties.Resources.employee;
            personel_btn.ImageAlign = ContentAlignment.MiddleLeft;
            personel_btn.Location = new Point(12, 338);
            personel_btn.Name = "personel_btn";
            personel_btn.Size = new Size(168, 48);
            personel_btn.TabIndex = 2;
            personel_btn.Text = "Personeller";
            personel_btn.UseVisualStyleBackColor = true;
            personel_btn.Click += personel_btn_Click;
            // 
            // depo_btn
            // 
            depo_btn.FlatStyle = FlatStyle.Popup;
            depo_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            depo_btn.ForeColor = Color.White;
            depo_btn.Image = Properties.Resources.warehouse;
            depo_btn.ImageAlign = ContentAlignment.MiddleLeft;
            depo_btn.Location = new Point(12, 254);
            depo_btn.Name = "depo_btn";
            depo_btn.Size = new Size(168, 48);
            depo_btn.TabIndex = 3;
            depo_btn.Text = "Depolar";
            depo_btn.UseVisualStyleBackColor = true;
            depo_btn.Click += depo_btn_Click;
            // 
            // magazaislemleri_btn
            // 
            magazaislemleri_btn.AutoSize = true;
            magazaislemleri_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            magazaislemleri_btn.ForeColor = Color.White;
            magazaislemleri_btn.Location = new Point(3, 305);
            magazaislemleri_btn.Name = "magazaislemleri_btn";
            magazaislemleri_btn.Size = new Size(178, 30);
            magazaislemleri_btn.TabIndex = 5;
            magazaislemleri_btn.Text = "Mağaza İşlemleri";
            // 
            // musteriislemleri_btn
            // 
            musteriislemleri_btn.AutoSize = true;
            musteriislemleri_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            musteriislemleri_btn.ForeColor = Color.White;
            musteriislemleri_btn.Location = new Point(3, 74);
            musteriislemleri_btn.Name = "musteriislemleri_btn";
            musteriislemleri_btn.Size = new Size(177, 30);
            musteriislemleri_btn.TabIndex = 6;
            musteriislemleri_btn.Text = "Müşteri İşlemleri";
            // 
            // musteri_btn
            // 
            musteri_btn.FlatStyle = FlatStyle.Popup;
            musteri_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            musteri_btn.ForeColor = Color.White;
            musteri_btn.Image = Properties.Resources.customer;
            musteri_btn.ImageAlign = ContentAlignment.MiddleLeft;
            musteri_btn.Location = new Point(12, 107);
            musteri_btn.Name = "musteri_btn";
            musteri_btn.Size = new Size(168, 48);
            musteri_btn.TabIndex = 7;
            musteri_btn.Text = "Müşteriler";
            musteri_btn.UseVisualStyleBackColor = true;
            musteri_btn.Click += musteri_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 18);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 11;
            label1.Text = "Yardımcı Asistan:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(152, 92);
            label3.Name = "label3";
            label3.Size = new Size(571, 63);
            label3.TabIndex = 13;
            label3.Text = "  Müşteri İşlemleri bölümünde \"Müşteriler\" bölümümüz var.\r\n  Bu bölümde BoldPencils'dan alışveriş yapmış müşterileri görüntüleyebilirsin.\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(152, 200);
            label4.Name = "label4";
            label4.Size = new Size(600, 168);
            label4.TabIndex = 14;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(152, 461);
            label5.Name = "label5";
            label5.Size = new Size(517, 84);
            label5.TabIndex = 15;
            label5.Text = "Mağaza İşlemleri bölümünde \"Personeller\" bölümümüz var.\r\nBu bölümde BoldPencils'da çalışan ekip arkadaşlarımızı görebilirsiniz.\r\n\r\n\r\n";
            // 
            // anasayfa_main_panel
            // 
            anasayfa_main_panel.BackColor = Color.FromArgb(27, 66, 66);
            anasayfa_main_panel.Controls.Add(label5);
            anasayfa_main_panel.Controls.Add(label1);
            anasayfa_main_panel.Controls.Add(label3);
            anasayfa_main_panel.Controls.Add(label4);
            anasayfa_main_panel.Dock = DockStyle.Right;
            anasayfa_main_panel.Location = new Point(210, 0);
            anasayfa_main_panel.Name = "anasayfa_main_panel";
            anasayfa_main_panel.Size = new Size(813, 682);
            anasayfa_main_panel.TabIndex = 16;
            // 
            // anasayfa_side_panel
            // 
            anasayfa_side_panel.BackColor = Color.FromArgb(9, 38, 53);
            anasayfa_side_panel.Controls.Add(label6);
            anasayfa_side_panel.Controls.Add(personel_btn);
            anasayfa_side_panel.Controls.Add(magazaislemleri_btn);
            anasayfa_side_panel.Controls.Add(depo_btn);
            anasayfa_side_panel.Controls.Add(musteriislemleri_btn);
            anasayfa_side_panel.Controls.Add(musteri_btn);
            anasayfa_side_panel.Controls.Add(urunislemleri_label);
            anasayfa_side_panel.Controls.Add(urunler_btn);
            anasayfa_side_panel.Dock = DockStyle.Left;
            anasayfa_side_panel.Location = new Point(0, 0);
            anasayfa_side_panel.Name = "anasayfa_side_panel";
            anasayfa_side_panel.Size = new Size(204, 682);
            anasayfa_side_panel.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(120, 37);
            label6.TabIndex = 11;
            label6.Text = "İşlemler";
            // 
            // AnasayfaPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(1023, 682);
            Controls.Add(anasayfa_side_panel);
            Controls.Add(anasayfa_main_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnasayfaPage";
            Text = "AnasayfaPage";
            anasayfa_main_panel.ResumeLayout(false);
            anasayfa_main_panel.PerformLayout();
            anasayfa_side_panel.ResumeLayout(false);
            anasayfa_side_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label urunislemleri_label;
        private Button urunler_btn;
        private Button personel_btn;
        private Button depo_btn;
        private Label magazaislemleri_btn;
        private Label musteriislemleri_btn;
        private Button musteri_btn;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Panel anasayfa_main_panel;
        private System.Windows.Forms.Panel anasayfa_side_panel;
        private Label label6;
    }
}