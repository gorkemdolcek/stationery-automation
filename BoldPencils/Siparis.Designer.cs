namespace BoldPencils
{
    partial class Siparis
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
            siparis_panel = new System.Windows.Forms.Panel();
            sipariscıkar_btn = new Button();
            siparisekle_btn = new Button();
            sıparis_listBox = new ListBox();
            siparis_label = new Label();
            siparis_textBox = new TextBox();
            siparis_panel.SuspendLayout();
            SuspendLayout();
            // 
            // siparis_panel
            // 
            siparis_panel.Controls.Add(siparis_textBox);
            siparis_panel.Controls.Add(sipariscıkar_btn);
            siparis_panel.Controls.Add(siparisekle_btn);
            siparis_panel.Controls.Add(sıparis_listBox);
            siparis_panel.Controls.Add(siparis_label);
            siparis_panel.Dock = DockStyle.Fill;
            siparis_panel.Location = new Point(0, 0);
            siparis_panel.Name = "siparis_panel";
            siparis_panel.Size = new Size(1007, 643);
            siparis_panel.TabIndex = 3;
            // 
            // sipariscıkar_btn
            // 
            sipariscıkar_btn.Location = new Point(233, 511);
            sipariscıkar_btn.Name = "sipariscıkar_btn";
            sipariscıkar_btn.Size = new Size(152, 56);
            sipariscıkar_btn.TabIndex = 6;
            sipariscıkar_btn.Text = "Sipariş Çıkar";
            sipariscıkar_btn.UseVisualStyleBackColor = true;
            // 
            // siparisekle_btn
            // 
            siparisekle_btn.Location = new Point(75, 511);
            siparisekle_btn.Name = "siparisekle_btn";
            siparisekle_btn.Size = new Size(152, 56);
            siparisekle_btn.TabIndex = 5;
            siparisekle_btn.Text = "Sipariş Ekle";
            siparisekle_btn.UseVisualStyleBackColor = true;
            // 
            // sıparis_listBox
            // 
            sıparis_listBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            sıparis_listBox.FormattingEnabled = true;
            sıparis_listBox.ItemHeight = 17;
            sıparis_listBox.Location = new Point(75, 97);
            sıparis_listBox.Name = "sıparis_listBox";
            sıparis_listBox.Size = new Size(837, 361);
            sıparis_listBox.TabIndex = 3;
            // 
            // siparis_label
            // 
            siparis_label.AutoSize = true;
            siparis_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            siparis_label.ForeColor = Color.White;
            siparis_label.Location = new Point(12, 26);
            siparis_label.Name = "siparis_label";
            siparis_label.Size = new Size(120, 32);
            siparis_label.TabIndex = 1;
            siparis_label.Text = "Siparişler";
            // 
            // siparis_textBox
            // 
            siparis_textBox.Location = new Point(75, 482);
            siparis_textBox.Name = "siparis_textBox";
            siparis_textBox.Size = new Size(310, 23);
            siparis_textBox.TabIndex = 7;
            // 
            // Siparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(1007, 643);
            Controls.Add(siparis_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Siparis";
            Text = "Siparis";
            siparis_panel.ResumeLayout(false);
            siparis_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel siparis_panel;
        private Label siparis_label;
        private ListBox sıparis_listBox;
        private Button siparisekle_btn;
        private Button sipariscıkar_btn;
        private TextBox siparis_textBox;
    }
}