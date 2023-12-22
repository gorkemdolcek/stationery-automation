namespace BoldPencils
{
    partial class Rapor
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
            rapor_panel = new System.Windows.Forms.Panel();
            raporcıkar_btn = new Button();
            raporekle_btn = new Button();
            rapor_listBox = new ListBox();
            rapor_label = new Label();
            rapor_textBox = new TextBox();
            rapor_panel.SuspendLayout();
            SuspendLayout();
            // 
            // rapor_panel
            // 
            rapor_panel.Controls.Add(rapor_textBox);
            rapor_panel.Controls.Add(raporcıkar_btn);
            rapor_panel.Controls.Add(raporekle_btn);
            rapor_panel.Controls.Add(rapor_listBox);
            rapor_panel.Controls.Add(rapor_label);
            rapor_panel.Dock = DockStyle.Fill;
            rapor_panel.Location = new Point(0, 0);
            rapor_panel.Name = "rapor_panel";
            rapor_panel.Size = new Size(1007, 643);
            rapor_panel.TabIndex = 3;
            // 
            // raporcıkar_btn
            // 
            raporcıkar_btn.Location = new Point(233, 528);
            raporcıkar_btn.Name = "raporcıkar_btn";
            raporcıkar_btn.Size = new Size(152, 56);
            raporcıkar_btn.TabIndex = 4;
            raporcıkar_btn.Text = "Rapor Çıkar";
            raporcıkar_btn.UseVisualStyleBackColor = true;
            // 
            // raporekle_btn
            // 
            raporekle_btn.Location = new Point(75, 528);
            raporekle_btn.Name = "raporekle_btn";
            raporekle_btn.Size = new Size(152, 56);
            raporekle_btn.TabIndex = 3;
            raporekle_btn.Text = "Rapor Ekle";
            raporekle_btn.UseVisualStyleBackColor = true;
            // 
            // rapor_listBox
            // 
            rapor_listBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rapor_listBox.FormattingEnabled = true;
            rapor_listBox.ItemHeight = 17;
            rapor_listBox.Location = new Point(75, 97);
            rapor_listBox.Name = "rapor_listBox";
            rapor_listBox.Size = new Size(837, 361);
            rapor_listBox.TabIndex = 2;
            // 
            // rapor_label
            // 
            rapor_label.AutoSize = true;
            rapor_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rapor_label.ForeColor = Color.White;
            rapor_label.Location = new Point(12, 26);
            rapor_label.Name = "rapor_label";
            rapor_label.Size = new Size(113, 32);
            rapor_label.TabIndex = 1;
            rapor_label.Text = "Raporlar";
            // 
            // rapor_textBox
            // 
            rapor_textBox.Location = new Point(75, 494);
            rapor_textBox.Name = "rapor_textBox";
            rapor_textBox.Size = new Size(310, 23);
            rapor_textBox.TabIndex = 5;
            // 
            // Rapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 66, 66);
            ClientSize = new Size(1007, 643);
            Controls.Add(rapor_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rapor";
            Text = "Rapor";
            rapor_panel.ResumeLayout(false);
            rapor_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel rapor_panel;
        private Label rapor_label;
        private Button raporcıkar_btn;
        private Button raporekle_btn;
        private ListBox rapor_listBox;
        private TextBox rapor_textBox;
    }
}