namespace WinFormsAppFinal
{
    public partial class Form1 : Form
    {
        private string user;
        private string pass;
        /*string user = ;
        string pass = "admin";*/
        string FailToLogin = "Sai mat Khau";

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string userName, string password)
        {
            InitializeComponent();
            this.user = userName;
            this.pass = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*txtUser.Text = user;
            txtPass.Text = pass;*/
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
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        bool checkLogin(string user, string pass)
        {
            if(user ==this.user && pass == this.pass) {
                return true;

            }
            return false;
        }
    }
}
