namespace BoldPencils
{
    partial class Satıs
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
            satıs_listBox = new ListBox();
            satıs_search_textBox = new TextBox();
            coktanaz_radiobtn = new RadioButton();
            azdancok_radiobtn = new RadioButton();
            verileriver_btn = new Button();
            arama_label = new Label();
            aylıksatıs_btn = new Button();
            yıllıksatıs_btn = new Button();
            satıs_label = new Label();
            satıs_panel = new System.Windows.Forms.Panel();
            satıspaneli_label = new Label();
            satıs_panel.SuspendLayout();
            SuspendLayout();
            // 
            // satıs_listBox
            // 
            satıs_listBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıs_listBox.FormattingEnabled = true;
            satıs_listBox.ItemHeight = 17;
            satıs_listBox.Location = new Point(61, 62);
            satıs_listBox.Name = "satıs_listBox";
            satıs_listBox.Size = new Size(679, 361);
            satıs_listBox.TabIndex = 0;
            // 
            // satıs_search_textBox
            // 
            satıs_search_textBox.Location = new Point(61, 456);
            satıs_search_textBox.Name = "satıs_search_textBox";
            satıs_search_textBox.Size = new Size(246, 23);
            satıs_search_textBox.TabIndex = 1;
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
            // aylıksatıs_btn
            // 
            aylıksatıs_btn.Location = new Point(418, 550);
            aylıksatıs_btn.Name = "aylıksatıs_btn";
            aylıksatıs_btn.Size = new Size(132, 39);
            aylıksatıs_btn.TabIndex = 6;
            aylıksatıs_btn.Text = "Bu Ayın Satışları";
            aylıksatıs_btn.UseVisualStyleBackColor = true;
            // 
            // yıllıksatıs_btn
            // 
            yıllıksatıs_btn.Location = new Point(418, 505);
            yıllıksatıs_btn.Name = "yıllıksatıs_btn";
            yıllıksatıs_btn.Size = new Size(132, 39);
            yıllıksatıs_btn.TabIndex = 7;
            yıllıksatıs_btn.Text = "Bu Yıllık Satıs";
            yıllıksatıs_btn.UseVisualStyleBackColor = true;
            // 
            // satıs_label
            // 
            satıs_label.AutoSize = true;
            satıs_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıs_label.ForeColor = Color.White;
            satıs_label.Location = new Point(418, 462);
            satıs_label.Name = "satıs_label";
            satıs_label.Size = new Size(57, 17);
            satıs_label.TabIndex = 8;
            satıs_label.Text = "İşlemler";
            // 
            // satıs_panel
            // 
            satıs_panel.BackColor = Color.FromArgb(27, 66, 66);
            satıs_panel.Controls.Add(satıspaneli_label);
            satıs_panel.Controls.Add(satıs_listBox);
            satıs_panel.Controls.Add(arama_label);
            satıs_panel.Controls.Add(satıs_label);
            satıs_panel.Controls.Add(satıs_search_textBox);
            satıs_panel.Controls.Add(azdancok_radiobtn);
            satıs_panel.Controls.Add(verileriver_btn);
            satıs_panel.Controls.Add(coktanaz_radiobtn);
            satıs_panel.Controls.Add(aylıksatıs_btn);
            satıs_panel.Controls.Add(yıllıksatıs_btn);
            satıs_panel.Dock = DockStyle.Fill;
            satıs_panel.Location = new Point(0, 0);
            satıs_panel.Name = "satıs_panel";
            satıs_panel.Size = new Size(813, 682);
            satıs_panel.TabIndex = 9;
            // 
            // satıspaneli_label
            // 
            satıspaneli_label.AutoSize = true;
            satıspaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıspaneli_label.ForeColor = Color.White;
            satıspaneli_label.Location = new Point(61, 42);
            satıspaneli_label.Name = "satıspaneli_label";
            satıspaneli_label.Size = new Size(79, 17);
            satıspaneli_label.TabIndex = 9;
            satıspaneli_label.Text = "Satış Paneli";
            // 
            // Satıs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(813, 682);
            Controls.Add(satıs_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Satıs";
            Text = "s";
            satıs_panel.ResumeLayout(false);
            satıs_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox satıs_listBox;
        private TextBox satıs_search_textBox;
        private RadioButton coktanaz_radiobtn;
        private RadioButton azdancok_radiobtn;
        private Button verileriver_btn;
        private Label arama_label;
        private Button aylıksatıs_btn;
        private Button yıllıksatıs_btn;
        private Label satıs_label;
        private System.Windows.Forms.Panel satıs_panel;
        private Label satıspaneli_label;
    }
}