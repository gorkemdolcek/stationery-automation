namespace BoldPencils
{
    partial class Stok
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
            stok_panel = new System.Windows.Forms.Panel();
            satıs_label = new Label();
            stokpaneli_label = new Label();
            stok_listBox = new ListBox();
            arama_label = new Label();
            stok_search_textBox = new TextBox();
            azdancok_radiobtn = new RadioButton();
            verileriver_btn = new Button();
            coktanaz_radiobtn = new RadioButton();
            stokekle_btn = new Button();
            stokcıkar_btn = new Button();
            stok_textBox = new TextBox();
            stok_panel.SuspendLayout();
            SuspendLayout();
            // 
            // stok_panel
            // 
            stok_panel.BackColor = Color.FromArgb(27, 66, 66);
            stok_panel.Controls.Add(stok_textBox);
            stok_panel.Controls.Add(satıs_label);
            stok_panel.Controls.Add(stokcıkar_btn);
            stok_panel.Controls.Add(stokekle_btn);
            stok_panel.Controls.Add(stokpaneli_label);
            stok_panel.Controls.Add(stok_listBox);
            stok_panel.Controls.Add(arama_label);
            stok_panel.Controls.Add(stok_search_textBox);
            stok_panel.Controls.Add(azdancok_radiobtn);
            stok_panel.Controls.Add(verileriver_btn);
            stok_panel.Controls.Add(coktanaz_radiobtn);
            stok_panel.Dock = DockStyle.Fill;
            stok_panel.Location = new Point(0, 0);
            stok_panel.Name = "stok_panel";
            stok_panel.Size = new Size(797, 643);
            stok_panel.TabIndex = 10;
            // 
            // satıs_label
            // 
            satıs_label.AutoSize = true;
            satıs_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıs_label.ForeColor = Color.White;
            satıs_label.Location = new Point(418, 462);
            satıs_label.Name = "satıs_label";
            satıs_label.Size = new Size(57, 17);
            satıs_label.TabIndex = 12;
            satıs_label.Text = "İşlemler";
            // 
            // stokpaneli_label
            // 
            stokpaneli_label.AutoSize = true;
            stokpaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            stokpaneli_label.ForeColor = Color.White;
            stokpaneli_label.Location = new Point(61, 42);
            stokpaneli_label.Name = "stokpaneli_label";
            stokpaneli_label.Size = new Size(77, 17);
            stokpaneli_label.TabIndex = 9;
            stokpaneli_label.Text = "Stok Paneli";
            // 
            // stok_listBox
            // 
            stok_listBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            stok_listBox.FormattingEnabled = true;
            stok_listBox.ItemHeight = 17;
            stok_listBox.Location = new Point(61, 62);
            stok_listBox.Name = "stok_listBox";
            stok_listBox.Size = new Size(679, 361);
            stok_listBox.TabIndex = 0;
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
            // stok_search_textBox
            // 
            stok_search_textBox.Location = new Point(61, 456);
            stok_search_textBox.Name = "stok_search_textBox";
            stok_search_textBox.Size = new Size(246, 23);
            stok_search_textBox.TabIndex = 1;
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
            // stokekle_btn
            // 
            stokekle_btn.Location = new Point(556, 550);
            stokekle_btn.Name = "stokekle_btn";
            stokekle_btn.Size = new Size(132, 39);
            stokekle_btn.TabIndex = 11;
            stokekle_btn.Text = "Manuel Stok Ekle";
            stokekle_btn.UseVisualStyleBackColor = true;
            // 
            // stokcıkar_btn
            // 
            stokcıkar_btn.Location = new Point(418, 550);
            stokcıkar_btn.Name = "stokcıkar_btn";
            stokcıkar_btn.Size = new Size(132, 39);
            stokcıkar_btn.TabIndex = 10;
            stokcıkar_btn.Text = "Manuel Stok Çıkar";
            stokcıkar_btn.UseVisualStyleBackColor = true;
            // 
            // stok_textBox
            // 
            stok_textBox.Location = new Point(418, 521);
            stok_textBox.Name = "stok_textBox";
            stok_textBox.Size = new Size(270, 23);
            stok_textBox.TabIndex = 13;
            // 
            // Stok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(797, 643);
            Controls.Add(stok_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stok";
            Text = "Stok";
            stok_panel.ResumeLayout(false);
            stok_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel stok_panel;
        private Label stokpaneli_label;
        private ListBox stok_listBox;
        private Label arama_label;
        private TextBox stok_search_textBox;
        private RadioButton azdancok_radiobtn;
        private Button verileriver_btn;
        private RadioButton coktanaz_radiobtn;
        private Label satıs_label;
        private TextBox stok_textBox;
        private Button stokcıkar_btn;
        private Button stokekle_btn;
    }
}