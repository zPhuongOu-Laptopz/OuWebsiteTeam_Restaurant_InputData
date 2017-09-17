using InputData_DAO.Services.LoginUser;
using System.Windows.Forms;

namespace InputData_BUS.Login
{
    public class LoginServices
    {
        public string RequestLogin(InputData_DTO.Models.UserLogin us, string usname, string ps)
        {
            return (new InputData_DAO.Services.LoginUser.LoginRequest { }.RequestLogin(us, usname, ps));
        }
    }
}
