namespace BoldPencils
{
    partial class Tedarikci
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
            tedarikci_panel = new System.Windows.Forms.Panel();
            tedarikcipaneli_label = new Label();
            tedarikci_listBox = new ListBox();
            arama_label = new Label();
            satıs_label = new Label();
            tedarikci_search_textBox = new TextBox();
            azdancok_radiobtn = new RadioButton();
            verileriver_btn = new Button();
            coktanaz_radiobtn = new RadioButton();
            tedarikcicıkar_btn = new Button();
            tedarikekle_btn = new Button();
            tedarikci_textBox = new TextBox();
            tedarikci_panel.SuspendLayout();
            SuspendLayout();
            // 
            // tedarikci_panel
            // 
            tedarikci_panel.BackColor = Color.FromArgb(27, 66, 66);
            tedarikci_panel.Controls.Add(tedarikci_textBox);
            tedarikci_panel.Controls.Add(tedarikcipaneli_label);
            tedarikci_panel.Controls.Add(tedarikci_listBox);
            tedarikci_panel.Controls.Add(arama_label);
            tedarikci_panel.Controls.Add(satıs_label);
            tedarikci_panel.Controls.Add(tedarikci_search_textBox);
            tedarikci_panel.Controls.Add(azdancok_radiobtn);
            tedarikci_panel.Controls.Add(verileriver_btn);
            tedarikci_panel.Controls.Add(coktanaz_radiobtn);
            tedarikci_panel.Controls.Add(tedarikcicıkar_btn);
            tedarikci_panel.Controls.Add(tedarikekle_btn);
            tedarikci_panel.Dock = DockStyle.Fill;
            tedarikci_panel.Location = new Point(0, 0);
            tedarikci_panel.Name = "tedarikci_panel";
            tedarikci_panel.Size = new Size(797, 643);
            tedarikci_panel.TabIndex = 10;
            // 
            // tedarikcipaneli_label
            // 
            tedarikcipaneli_label.AutoSize = true;
            tedarikcipaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tedarikcipaneli_label.ForeColor = Color.White;
            tedarikcipaneli_label.Location = new Point(61, 42);
            tedarikcipaneli_label.Name = "tedarikcipaneli_label";
            tedarikcipaneli_label.Size = new Size(105, 17);
            tedarikcipaneli_label.TabIndex = 9;
            tedarikcipaneli_label.Text = "Tedarikçi Paneli";
            // 
            // tedarikci_listBox
            // 
            tedarikci_listBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tedarikci_listBox.FormattingEnabled = true;
            tedarikci_listBox.ItemHeight = 17;
            tedarikci_listBox.Location = new Point(61, 62);
            tedarikci_listBox.Name = "tedarikci_listBox";
            tedarikci_listBox.Size = new Size(679, 361);
            tedarikci_listBox.TabIndex = 0;
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
            satıs_label.Location = new Point(418, 462);
            satıs_label.Name = "satıs_label";
            satıs_label.Size = new Size(57, 17);
            satıs_label.TabIndex = 8;
            satıs_label.Text = "İşlemler";
            // 
            // tedarikci_search_textBox
            // 
            tedarikci_search_textBox.Location = new Point(61, 456);
            tedarikci_search_textBox.Name = "tedarikci_search_textBox";
            tedarikci_search_textBox.Size = new Size(246, 23);
            tedarikci_search_textBox.TabIndex = 1;
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
            // tedarikcicıkar_btn
            // 
            tedarikcicıkar_btn.Location = new Point(418, 550);
            tedarikcicıkar_btn.Name = "tedarikcicıkar_btn";
            tedarikcicıkar_btn.Size = new Size(132, 39);
            tedarikcicıkar_btn.TabIndex = 6;
            tedarikcicıkar_btn.Text = "Tedarikçi Çıkar";
            tedarikcicıkar_btn.UseVisualStyleBackColor = true;
            // 
            // tedarikekle_btn
            // 
            tedarikekle_btn.Location = new Point(556, 550);
            tedarikekle_btn.Name = "tedarikekle_btn";
            tedarikekle_btn.Size = new Size(132, 39);
            tedarikekle_btn.TabIndex = 7;
            tedarikekle_btn.Text = "Tedarikçi Ekle";
            tedarikekle_btn.UseVisualStyleBackColor = true;
            // 
            // tedarikci_textBox
            // 
            tedarikci_textBox.Location = new Point(418, 520);
            tedarikci_textBox.Name = "tedarikci_textBox";
            tedarikci_textBox.Size = new Size(270, 23);
            tedarikci_textBox.TabIndex = 10;
            // 
            // Tedarikci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(797, 643);
            Controls.Add(tedarikci_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tedarikci";
            Text = "Tedarikci";
            tedarikci_panel.ResumeLayout(false);
            tedarikci_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel tedarikci_panel;
        private Label tedarikcipaneli_label;
        private ListBox tedarikci_listBox;
        private Label arama_label;
        private Label satıs_label;
        private TextBox tedarikci_search_textBox;
        private RadioButton azdancok_radiobtn;
        private Button verileriver_btn;
        private RadioButton coktanaz_radiobtn;
        private Button tedarikcicıkar_btn;
        private Button tedarikekle_btn;
        private TextBox tedarikci_textBox;
    }
}