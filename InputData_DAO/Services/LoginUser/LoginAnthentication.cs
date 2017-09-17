using InputData_DTO.Models;

namespace InputData_DAO.Services.LoginUser
{
    public class LoginAnthentication
    {
        public bool CheckAuthenticationLogin(UserLogin us)
        {
            if (us.isStatus == true)
                return true;
            return false;
        }
    }
}
