namespace BoldPencils
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kullan�c�_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_girisyap_btn_Click(object sender, EventArgs e)
        {
            if (kullan�c�_textBox.Text == "admin" && sifre_textBox.Text == "1234")
            {
                MessageBox.Show("Giri� Ba�ar�l�");
                Panel panel = new Panel();
                panel.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� Ad� veya �ifre Hatal�");
                kullan�c�_textBox.Text = ""; 
                sifre_textBox.Text = ""; 
            }


        }

        private void sifre_textBox_TextChanged(object sender, EventArgs e)
        {
            sifre_textBox.PasswordChar = '*'; 

        }
    }
}
