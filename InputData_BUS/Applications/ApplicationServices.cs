using InputData_DAO;

namespace InputData_BUS.Applications
{
    public class ApplicationServices
    {
        public string ConfirmExitApplication()
        {
            return (new InputData_DAO.Services.Applications.ApplicationRequest { }.ConfirmExitApplication());
        }

        public bool ConfirmLogoutApplication()
        {
            return (new InputData_DAO.Services.Applications.ApplicationRequest { }.ConfirmLogoutApplication());
        }

        public void ErrorWhileProcessing()
        {
            new InputData_DAO.Services.Applications.ApplicationRequest { }.ErrorWhileProcessing();
        }

        public void ErrorWhileConnectDatabase()
        {
            new InputData_DAO.Services.Applications.ApplicationRequest { }.ErrorWhileConnectDatabase();
        }

        public void Input_Successful()
        {
            new InputData_DAO.Services.Applications.ApplicationRequest { }.Input_Successful();
        }
    }
}
