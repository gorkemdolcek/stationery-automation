namespace BoldPencils
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kullanýcý_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_girisyap_btn_Click(object sender, EventArgs e)
        {
            if (kullanýcý_textBox.Text == "admin" && sifre_textBox.Text == "1234")
            {
                MessageBox.Show("Giriþ Baþarýlý");
                Panel panel = new Panel();
                panel.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
                kullanýcý_textBox.Text = ""; 
                sifre_textBox.Text = ""; 
            }


        }

        private void sifre_textBox_TextChanged(object sender, EventArgs e)
        {
            sifre_textBox.PasswordChar = '*'; 

        }
    }
}
