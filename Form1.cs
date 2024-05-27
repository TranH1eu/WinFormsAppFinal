namespace WinFormsAppFinal
{
    public partial class Form1 : Form
    {

        string user = "admin";
        string pass = "admin";
        string FailToLogin = "Sai mat Khau";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Space_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(checkLogin(txtUser.Text, txtPass.Text) )
            {
                ListItem f = new ListItem();
                f.Show();
                this.Hide();

            }
            else label1.Text = "Sai tai khoan hoac mat khau!";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool checkLogin(string user, string pass)
        {
            if(user == this.user && pass == this.pass) {
                return true;

            }
            return false;
        }
    }
}
