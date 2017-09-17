using System.Windows.Forms;

namespace InputData_DAO.Services.LoginUser
{
    public class LoginError
    {
        public void LoginFailed(int numbercheck)
        {
            MessageBox.Show("Wrong Username or Password - " + numbercheck.ToString() + " times", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void UsernameNULL()
        {
            MessageBox.Show("Username must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PasswordNULL()
        {
            MessageBox.Show("Password must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
