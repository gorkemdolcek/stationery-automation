namespace BoldPencils
{
    partial class Kategori
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
            kategori_label = new Label();
            kategori_panel = new System.Windows.Forms.Panel();
            kategorilerListView = new ListView();
            KategoriID = new ColumnHeader();
            KategoriAdi = new ColumnHeader();
            kategori_textBox = new TextBox();
            kategoriekle_btn = new Button();
            kategoricıkar_btn = new Button();
            kategori_panel.SuspendLayout();
            SuspendLayout();
            // 
            // kategori_label
            // 
            kategori_label.AutoSize = true;
            kategori_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kategori_label.ForeColor = Color.White;
            kategori_label.Location = new Point(12, 26);
            kategori_label.Name = "kategori_label";
            kategori_label.Size = new Size(142, 32);
            kategori_label.TabIndex = 1;
            kategori_label.Text = "Kategoriler";
            // 
            // kategori_panel
            // 
            kategori_panel.Controls.Add(kategorilerListView);
            kategori_panel.Controls.Add(kategori_textBox);
            kategori_panel.Controls.Add(kategoriekle_btn);
            kategori_panel.Controls.Add(kategoricıkar_btn);
            kategori_panel.Controls.Add(kategori_label);
            kategori_panel.Dock = DockStyle.Fill;
            kategori_panel.Location = new Point(0, 0);
            kategori_panel.Name = "kategori_panel";
            kategori_panel.Size = new Size(1023, 682);
            kategori_panel.TabIndex = 2;
            kategori_panel.Paint += kategori_panel_Paint;
            // 
            // kategorilerListView
            // 
            kategorilerListView.Columns.AddRange(new ColumnHeader[] { KategoriID, KategoriAdi });
            kategorilerListView.Location = new Point(61, 121);
            kategorilerListView.Name = "kategorilerListView";
            kategorilerListView.Size = new Size(880, 390);
            kategorilerListView.TabIndex = 17;
            kategorilerListView.UseCompatibleStateImageBehavior = false;
            kategorilerListView.View = View.Details;
            // 
            // KategoriID
            // 
            KategoriID.Text = "KategoriID";
            // 
            // KategoriAdi
            // 
            KategoriAdi.Text = "KategoriAdi";
            // 
            // kategori_textBox
            // 
            kategori_textBox.Location = new Point(61, 517);
            kategori_textBox.Name = "kategori_textBox";
            kategori_textBox.PlaceholderText = "id, kategoriadi";
            kategori_textBox.Size = new Size(270, 23);
            kategori_textBox.TabIndex = 16;
            kategori_textBox.TextChanged += kategori_textBox_TextChanged;
            // 
            // kategoriekle_btn
            // 
            kategoriekle_btn.Location = new Point(61, 546);
            kategoriekle_btn.Name = "kategoriekle_btn";
            kategoriekle_btn.Size = new Size(132, 39);
            kategoriekle_btn.TabIndex = 14;
            kategoriekle_btn.Text = "Kategori Ekle";
            kategoriekle_btn.UseVisualStyleBackColor = true;
            kategoriekle_btn.Click += kategoriekle_btn_Click;
            // 
            // kategoricıkar_btn
            // 
            kategoricıkar_btn.Location = new Point(199, 546);
            kategoricıkar_btn.Name = "kategoricıkar_btn";
            kategoricıkar_btn.Size = new Size(132, 39);
            kategoricıkar_btn.TabIndex = 15;
            kategoricıkar_btn.Text = "Kategori Çıkar";
            kategoricıkar_btn.UseVisualStyleBackColor = true;
            kategoricıkar_btn.Click += kategoricıkar_btn_Click;
            // 
            // Kategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(1023, 682);
            Controls.Add(kategori_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kategori";
            Text = "Kategori";
            kategori_panel.ResumeLayout(false);
            kategori_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label kategori_label;
        private System.Windows.Forms.Panel kategori_panel;
        private TextBox kategori_textBox;
        private Button kategoriekle_btn;
        private Button kategoricıkar_btn;
        private ListView kategorilerListView;
        private ColumnHeader KategoriID;
        private ColumnHeader KategoriAdi;
    }
}