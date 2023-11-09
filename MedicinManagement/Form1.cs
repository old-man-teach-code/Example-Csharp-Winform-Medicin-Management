namespace MedicinManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username == "linh" && password == "123") { 
                AppData.isLogin = true;
                AppData.username = username;
                AppData.password = password;
                Close();
            }
        }
    }
}