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
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            eklecıkar_label = new Label();
            yıllıkazurun_btn = new Button();
            aylıkazurun_btn = new Button();
            urunpaneli_label = new Label();
            urun_listBox = new ListBox();
            arama_label = new Label();
            urun_label = new Label();
            urun_search_textBox = new TextBox();
            azdancok_radiobtn = new RadioButton();
            verileriver_btn = new Button();
            coktanaz_radiobtn = new RadioButton();
            aylıkcokurun_btn = new Button();
            yıllıkcokurun_btn = new Button();
            urun_panel.SuspendLayout();
            SuspendLayout();
            // 
            // urun_panel
            // 
            urun_panel.BackColor = Color.FromArgb(27, 66, 66);
            urun_panel.Controls.Add(textBox1);
            urun_panel.Controls.Add(button2);
            urun_panel.Controls.Add(button1);
            urun_panel.Controls.Add(eklecıkar_label);
            urun_panel.Controls.Add(yıllıkazurun_btn);
            urun_panel.Controls.Add(aylıkazurun_btn);
            urun_panel.Controls.Add(urunpaneli_label);
            urun_panel.Controls.Add(urun_listBox);
            urun_panel.Controls.Add(arama_label);
            urun_panel.Controls.Add(urun_label);
            urun_panel.Controls.Add(urun_search_textBox);
            urun_panel.Controls.Add(azdancok_radiobtn);
            urun_panel.Controls.Add(verileriver_btn);
            urun_panel.Controls.Add(coktanaz_radiobtn);
            urun_panel.Controls.Add(aylıkcokurun_btn);
            urun_panel.Controls.Add(yıllıkcokurun_btn);
            urun_panel.Dock = DockStyle.Fill;
            urun_panel.Location = new Point(0, 0);
            urun_panel.Name = "urun_panel";
            urun_panel.Size = new Size(813, 682);
            urun_panel.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(513, 485);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(632, 521);
            button2.Name = "button2";
            button2.Size = new Size(108, 39);
            button2.TabIndex = 14;
            button2.Text = "Ürün Çıkar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(513, 521);
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
            eklecıkar_label.Location = new Point(513, 456);
            eklecıkar_label.Name = "eklecıkar_label";
            eklecıkar_label.Size = new Size(70, 17);
            eklecıkar_label.TabIndex = 12;
            eklecıkar_label.Text = "Ekle/Çıkar";
            // 
            // yıllıkazurun_btn
            // 
            yıllıkazurun_btn.Location = new Point(356, 566);
            yıllıkazurun_btn.Name = "yıllıkazurun_btn";
            yıllıkazurun_btn.Size = new Size(138, 39);
            yıllıkazurun_btn.TabIndex = 11;
            yıllıkazurun_btn.Text = "Bu Yıl En AZ Satılan Ürünler";
            yıllıkazurun_btn.UseVisualStyleBackColor = true;
            // 
            // aylıkazurun_btn
            // 
            aylıkazurun_btn.Location = new Point(356, 611);
            aylıkazurun_btn.Name = "aylıkazurun_btn";
            aylıkazurun_btn.Size = new Size(138, 39);
            aylıkazurun_btn.TabIndex = 10;
            aylıkazurun_btn.Text = "Bu Ay En AZ Satılan Ürünler";
            aylıkazurun_btn.UseVisualStyleBackColor = true;
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
            // urun_listBox
            // 
            urun_listBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urun_listBox.FormattingEnabled = true;
            urun_listBox.ItemHeight = 17;
            urun_listBox.Location = new Point(61, 62);
            urun_listBox.Name = "urun_listBox";
            urun_listBox.Size = new Size(679, 361);
            urun_listBox.TabIndex = 0;
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
            urun_label.Location = new Point(356, 456);
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
            // azdancok_radiobtn
            // 
            azdancok_radiobtn.AutoSize = true;
            azdancok_radiobtn.ForeColor = Color.White;
            azdancok_radiobtn.Location = new Point(61, 505);
            azdancok_radiobtn.Name = "azdancok_radiobtn";
            azdancok_radiobtn.Size = new Size(120, 19);
            azdancok_radiobtn.TabIndex = 3;
            azdancok_radiobtn.TabStop = true;
            azdancok_radiobtn.Text = "Azdan Çoğa Sırala";
            azdancok_radiobtn.UseVisualStyleBackColor = true;
            // 
            // verileriver_btn
            // 
            verileriver_btn.Location = new Point(99, 569);
            verileriver_btn.Name = "verileriver_btn";
            verileriver_btn.Size = new Size(152, 45);
            verileriver_btn.TabIndex = 4;
            verileriver_btn.Text = "Verileri Ver";
            verileriver_btn.UseVisualStyleBackColor = true;
            // 
            // coktanaz_radiobtn
            // 
            coktanaz_radiobtn.AutoSize = true;
            coktanaz_radiobtn.ForeColor = Color.White;
            coktanaz_radiobtn.Location = new Point(61, 530);
            coktanaz_radiobtn.Name = "coktanaz_radiobtn";
            coktanaz_radiobtn.Size = new Size(116, 19);
            coktanaz_radiobtn.TabIndex = 2;
            coktanaz_radiobtn.TabStop = true;
            coktanaz_radiobtn.Text = "Çoktan Aza Sırala";
            coktanaz_radiobtn.UseVisualStyleBackColor = true;
            // 
            // aylıkcokurun_btn
            // 
            aylıkcokurun_btn.Location = new Point(356, 521);
            aylıkcokurun_btn.Name = "aylıkcokurun_btn";
            aylıkcokurun_btn.Size = new Size(138, 39);
            aylıkcokurun_btn.TabIndex = 6;
            aylıkcokurun_btn.Text = "Bu Ay En ÇOK Satılan Ürünler";
            aylıkcokurun_btn.UseVisualStyleBackColor = true;
            // 
            // yıllıkcokurun_btn
            // 
            yıllıkcokurun_btn.Location = new Point(356, 476);
            yıllıkcokurun_btn.Name = "yıllıkcokurun_btn";
            yıllıkcokurun_btn.Size = new Size(138, 39);
            yıllıkcokurun_btn.TabIndex = 7;
            yıllıkcokurun_btn.Text = "Bu Yıl En ÇOK Satılan Ürünler";
            yıllıkcokurun_btn.UseVisualStyleBackColor = true;
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
        private ListBox urun_listBox;
        private Label arama_label;
        private Label urun_label;
        private TextBox urun_search_textBox;
        private RadioButton azdancok_radiobtn;
        private Button verileriver_btn;
        private RadioButton coktanaz_radiobtn;
        private Button aylıkcokurun_btn;
        private Button yıllıkcokurun_btn;
        private Button yıllıkazurun_btn;
        private Button aylıkazurun_btn;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label eklecıkar_label;
    }
}