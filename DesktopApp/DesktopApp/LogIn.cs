using DAL;
using LL.User_related;
using Classes;
using LL;

namespace DesktopApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
			ActiveControl = EmailTBX;
		}

        private void LogInButton_Click(object sender, EventArgs e)
		{
			//MainPage mainPage = new MainPage();
			//mainPage.Show();
			//Hide();

			LoginManager loginManager = new LoginManager(new UserDAO());

			string email = EmailTBX.Text;
			string password = PasswordTBX.Text;

			if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
			{
				User user = loginManager.Login(email, password);
				if (user != null)
				{
					MainPage mainform = new MainPage(user);
					mainform.Show();
					Hide();
				}
				else
				{
					MessageBox.Show("Wrong email or password");
				}
			}
			else
			{
				MessageBox.Show("Please enter data in all fields!");
			}
		}

		private void EmailTBX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				SendKeys.Send("{TAB}");
			}
		}

		private void PasswordTBX_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				LogInButton_Click(this, new EventArgs());
			}
		}
	}
}