namespace BoldPencils
{
    partial class Panel
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
            components = new System.ComponentModel.Container();
            side_panel = new System.Windows.Forms.Panel();
            kategori_btn = new Button();
            label1 = new Label();
            emek_btn = new Button();
            cikisyap_btn = new Button();
            anasayfa_btn = new Button();
            pictureBox1 = new PictureBox();
            page_panel = new System.Windows.Forms.Panel();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sipariş_btn = new Button();
            side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // side_panel
            // 
            side_panel.BackColor = Color.FromArgb(9, 38, 53);
            side_panel.Controls.Add(kategori_btn);
            side_panel.Controls.Add(sipariş_btn);
            side_panel.Controls.Add(label1);
            side_panel.Controls.Add(emek_btn);
            side_panel.Controls.Add(cikisyap_btn);
            side_panel.Controls.Add(anasayfa_btn);
            side_panel.Controls.Add(pictureBox1);
            side_panel.Dock = DockStyle.Left;
            side_panel.Location = new Point(0, 0);
            side_panel.Name = "side_panel";
            side_panel.Size = new Size(163, 682);
            side_panel.TabIndex = 0;
            // 
            // kategori_btn
            // 
            kategori_btn.FlatStyle = FlatStyle.Popup;
            kategori_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kategori_btn.ForeColor = Color.White;
            kategori_btn.Image = Properties.Resources.category;
            kategori_btn.ImageAlign = ContentAlignment.MiddleLeft;
            kategori_btn.Location = new Point(5, 270);
            kategori_btn.Name = "kategori_btn";
            kategori_btn.Size = new Size(153, 45);
            kategori_btn.TabIndex = 8;
            kategori_btn.Text = "Kategoriler";
            kategori_btn.UseVisualStyleBackColor = true;
            kategori_btn.Click += kategori_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 150);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 6;
            label1.Text = "BoldPencils";
            // 
            // emek_btn
            // 
            emek_btn.FlatStyle = FlatStyle.Popup;
            emek_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            emek_btn.ForeColor = Color.White;
            emek_btn.Image = Properties.Resources.sponsor;
            emek_btn.ImageAlign = ContentAlignment.MiddleLeft;
            emek_btn.Location = new Point(4, 574);
            emek_btn.Name = "emek_btn";
            emek_btn.Size = new Size(153, 45);
            emek_btn.TabIndex = 4;
            emek_btn.Text = "Yapanlar";
            emek_btn.UseVisualStyleBackColor = true;
            emek_btn.Click += emek_btn_Click;
            // 
            // cikisyap_btn
            // 
            cikisyap_btn.FlatStyle = FlatStyle.Popup;
            cikisyap_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cikisyap_btn.ForeColor = Color.White;
            cikisyap_btn.Image = Properties.Resources.logout;
            cikisyap_btn.ImageAlign = ContentAlignment.MiddleLeft;
            cikisyap_btn.Location = new Point(4, 625);
            cikisyap_btn.Name = "cikisyap_btn";
            cikisyap_btn.Size = new Size(153, 45);
            cikisyap_btn.TabIndex = 3;
            cikisyap_btn.Text = "Çıkıs Yap";
            cikisyap_btn.UseVisualStyleBackColor = true;
            cikisyap_btn.Click += cikisyap_btn_Click;
            // 
            // anasayfa_btn
            // 
            anasayfa_btn.FlatStyle = FlatStyle.Popup;
            anasayfa_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anasayfa_btn.ForeColor = Color.White;
            anasayfa_btn.Image = Properties.Resources.home;
            anasayfa_btn.ImageAlign = ContentAlignment.MiddleLeft;
            anasayfa_btn.Location = new Point(5, 219);
            anasayfa_btn.Name = "anasayfa_btn";
            anasayfa_btn.Size = new Size(153, 45);
            anasayfa_btn.TabIndex = 1;
            anasayfa_btn.Text = "Anasayfa";
            anasayfa_btn.UseVisualStyleBackColor = true;
            anasayfa_btn.Click += anasayfa_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logotrans;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // page_panel
            // 
            page_panel.BackColor = Color.FromArgb(27, 66, 66);
            page_panel.Dock = DockStyle.Fill;
            page_panel.Location = new Point(163, 0);
            page_panel.Name = "page_panel";
            page_panel.Size = new Size(1023, 682);
            page_panel.TabIndex = 1;
            page_panel.Paint += page_panel_Paint;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // sipariş_btn
            // 
            sipariş_btn.FlatStyle = FlatStyle.Popup;
            sipariş_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sipariş_btn.ForeColor = Color.White;
            sipariş_btn.Image = Properties.Resources.shopping_bag;
            sipariş_btn.ImageAlign = ContentAlignment.MiddleLeft;
            sipariş_btn.Location = new Point(5, 321);
            sipariş_btn.Name = "sipariş_btn";
            sipariş_btn.Size = new Size(153, 45);
            sipariş_btn.TabIndex = 7;
            sipariş_btn.Text = "Siparişler";
            sipariş_btn.UseVisualStyleBackColor = true;
            sipariş_btn.Click += sipariş_btn_Click;
            // 
            // Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1186, 682);
            Controls.Add(page_panel);
            Controls.Add(side_panel);
            Name = "Panel";
            Text = "BoldPencils/Admin Panel";
            side_panel.ResumeLayout(false);
            side_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel side_panel;
        private PictureBox pictureBox1;
        private Button cikisyap_btn;
        private Button anasayfa_btn;
        private System.Windows.Forms.Panel page_panel;
        private Button emek_btn;
        private Button kategori_btn;
        private Label label1;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button sipariş_btn;
    }
}