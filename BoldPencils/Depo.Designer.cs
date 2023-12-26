namespace BoldPencils
{
    partial class Depo
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
            depo_panel = new System.Windows.Forms.Panel();
            depo_ListView1 = new ListView();
            DepoIDColumn = new ColumnHeader();
            depopaneli_label = new Label();
            arama_label = new Label();
            depo_label = new Label();
            depo_search_textBox = new TextBox();
            depoçıkar_btn = new Button();
            depoekle_btn = new Button();
            DepoDetayID = new ColumnHeader();
            UrunID = new ColumnHeader();
            UrunAdet = new ColumnHeader();
            depo_panel.SuspendLayout();
            SuspendLayout();
            // 
            // depo_panel
            // 
            depo_panel.BackColor = Color.FromArgb(27, 66, 66);
            depo_panel.Controls.Add(depo_ListView1);
            depo_panel.Controls.Add(depopaneli_label);
            depo_panel.Controls.Add(arama_label);
            depo_panel.Controls.Add(depo_label);
            depo_panel.Controls.Add(depo_search_textBox);
            depo_panel.Controls.Add(depoçıkar_btn);
            depo_panel.Controls.Add(depoekle_btn);
            depo_panel.Dock = DockStyle.Fill;
            depo_panel.Location = new Point(0, 0);
            depo_panel.Name = "depo_panel";
            depo_panel.Size = new Size(797, 643);
            depo_panel.TabIndex = 10;
            // 
            // depo_ListView1
            // 
            depo_ListView1.Alignment = ListViewAlignment.SnapToGrid;
            depo_ListView1.AutoArrange = false;
            depo_ListView1.Columns.AddRange(new ColumnHeader[] { DepoIDColumn, DepoDetayID, UrunID, UrunAdet });
            depo_ListView1.FullRowSelect = true;
            depo_ListView1.Location = new Point(61, 62);
            depo_ListView1.Name = "depo_ListView1";
            depo_ListView1.Size = new Size(679, 361);
            depo_ListView1.TabIndex = 12;
            depo_ListView1.UseCompatibleStateImageBehavior = false;
            depo_ListView1.View = View.Details;
            // 
            // DepoIDColumn
            // 
            DepoIDColumn.Text = "DepoID";
            DepoIDColumn.Width = 50;
            // 
            // depopaneli_label
            // 
            depopaneli_label.AutoSize = true;
            depopaneli_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            depopaneli_label.ForeColor = Color.White;
            depopaneli_label.Location = new Point(61, 42);
            depopaneli_label.Name = "depopaneli_label";
            depopaneli_label.Size = new Size(83, 17);
            depopaneli_label.TabIndex = 9;
            depopaneli_label.Text = "Depo Paneli";
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
            // depo_label
            // 
            depo_label.AutoSize = true;
            depo_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            depo_label.ForeColor = Color.White;
            depo_label.Location = new Point(418, 435);
            depo_label.Name = "depo_label";
            depo_label.Size = new Size(57, 17);
            depo_label.TabIndex = 8;
            depo_label.Text = "İşlemler";
            // 
            // depo_search_textBox
            // 
            depo_search_textBox.Location = new Point(61, 455);
            depo_search_textBox.Name = "depo_search_textBox";
            depo_search_textBox.Size = new Size(246, 23);
            depo_search_textBox.TabIndex = 1;
            // 
            // depoçıkar_btn
            // 
            depoçıkar_btn.Location = new Point(556, 455);
            depoçıkar_btn.Name = "depoçıkar_btn";
            depoçıkar_btn.Size = new Size(132, 39);
            depoçıkar_btn.TabIndex = 6;
            depoçıkar_btn.Text = "Depo Çıkar";
            depoçıkar_btn.UseVisualStyleBackColor = true;
            // 
            // depoekle_btn
            // 
            depoekle_btn.Location = new Point(418, 455);
            depoekle_btn.Name = "depoekle_btn";
            depoekle_btn.Size = new Size(132, 39);
            depoekle_btn.TabIndex = 7;
            depoekle_btn.Text = "Depo Ekle";
            depoekle_btn.UseVisualStyleBackColor = true;
            // 
            // DepoDetayID
            // 
            DepoDetayID.Text = "DepoDetayID";
            // 
            // UrunID
            // 
            UrunID.Text = "UrunID";
            // 
            // UrunAdet
            // 
            UrunAdet.Text = "UrunAdet";
            // 
            // Depo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(797, 643);
            Controls.Add(depo_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Depo";
            Text = "Depo";
            depo_panel.ResumeLayout(false);
            depo_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel depo_panel;
        private Label depopaneli_label;
        private Label arama_label;
        private Label depo_label;
        private TextBox depo_search_textBox;
        private Button depoçıkar_btn;
        private Button depoekle_btn;
        private ListView depo_ListView1;
        private ColumnHeader MusteriID;
        private ColumnHeader DepoIDColumn;
        private ColumnHeader DepoDetayID;
        private ColumnHeader UrunID;
        private ColumnHeader UrunAdet;
    }
}