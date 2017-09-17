using System.Windows.Forms;
using InputData_DTO;

namespace InputData_DAO.Services.LoginUser
{
    public class LoginRequest
    {
        LoginSuccess lgsuccesss;
        LoginAnthentication lgauthen;
        public LoginRequest()
        {
            lgsuccesss = new LoginSuccess();
            lgauthen = new LoginAnthentication();
        }

        public string RequestLogin(InputData_DTO.Models.UserLogin us, string username, string password)
        {
            if (username == "" || password == "")
            {
                if (username == "")
                {
                    //MessageBox.Show("Input Username, Please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "Login Failed - Username is required";
                }
                else
                {
                    //MessageBox.Show("Input Password, Please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "Login Failed - Password is required";
                }                
            }
            else
            {

                bool checkauthentication = lgauthen.CheckAuthenticationLogin(us);
                if (us.username == username && us.password == password)
                {
                    if (checkauthentication == true)
                    {
                        return "Login Success";
                    }
                    else
                    {
                        return "Account was denied";
                    }
                }
                else
                {
                    return "Username or Password is incorrect";
                }
            }
        }
    }
}
