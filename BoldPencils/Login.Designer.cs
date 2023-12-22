namespace BoldPencils
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            login_logo_pictureBox = new PictureBox();
            kullanıcı_textBox = new TextBox();
            sifre_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login_girisyap_btn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)login_logo_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // login_logo_pictureBox
            // 
            login_logo_pictureBox.Image = (Image)resources.GetObject("login_logo_pictureBox.Image");
            login_logo_pictureBox.Location = new Point(12, 99);
            login_logo_pictureBox.Name = "login_logo_pictureBox";
            login_logo_pictureBox.Size = new Size(318, 222);
            login_logo_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            login_logo_pictureBox.TabIndex = 0;
            login_logo_pictureBox.TabStop = false;
            // 
            // kullanıcı_textBox
            // 
            kullanıcı_textBox.Location = new Point(364, 119);
            kullanıcı_textBox.Name = "kullanıcı_textBox";
            kullanıcı_textBox.Size = new Size(183, 23);
            kullanıcı_textBox.TabIndex = 1;
            kullanıcı_textBox.TextChanged += kullanıcı_textBox_TextChanged;
            // 
            // sifre_textBox
            // 
            sifre_textBox.Location = new Point(364, 186);
            sifre_textBox.Name = "sifre_textBox";
            sifre_textBox.Size = new Size(183, 23);
            sifre_textBox.TabIndex = 2;
            sifre_textBox.TextChanged += sifre_textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(364, 99);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(364, 166);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // login_girisyap_btn
            // 
            login_girisyap_btn.FlatStyle = FlatStyle.Popup;
            login_girisyap_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            login_girisyap_btn.ForeColor = Color.White;
            login_girisyap_btn.Image = Properties.Resources.login;
            login_girisyap_btn.ImageAlign = ContentAlignment.MiddleLeft;
            login_girisyap_btn.Location = new Point(364, 269);
            login_girisyap_btn.Name = "login_girisyap_btn";
            login_girisyap_btn.Size = new Size(183, 52);
            login_girisyap_btn.TabIndex = 5;
            login_girisyap_btn.Text = "Giriş Yap";
            login_girisyap_btn.UseVisualStyleBackColor = true;
            login_girisyap_btn.Click += login_girisyap_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 6;
            label3.Text = "BoldPencils";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(364, 45);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 7;
            label4.Text = "Lütfen Giriş Yapın";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 41);
            label5.Name = "label5";
            label5.Size = new Size(219, 21);
            label5.TabIndex = 8;
            label5.Text = "Admin Panel'e hoşgeldiniz.";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 38, 53);
            ClientSize = new Size(584, 364);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(login_girisyap_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sifre_textBox);
            Controls.Add(kullanıcı_textBox);
            Controls.Add(login_logo_pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "BoldPencils Login";
            ((System.ComponentModel.ISupportInitialize)login_logo_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox login_logo_pictureBox;
        private TextBox kullanıcı_textBox;
        private TextBox sifre_textBox;
        private Label label1;
        private Label label2;
        private Button login_girisyap_btn;
        private Label label3;
        private Label label4;
        private Label label5;
        private NotifyIcon notifyIcon1;
    }
}
