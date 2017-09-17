using System.Windows.Forms;

namespace InputData_DAO.Services.Applications
{
    public class ApplicationRequest
    {
        public string ConfirmExitApplication()
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            return "Ready to Login";
        }

        public bool ConfirmLogoutApplication()
        {
            if (MessageBox.Show("Are you sure to logout?", "Logout Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public void ErrorWhileProcessing()
        {
            MessageBox.Show("An error occurred while processing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ErrorWhileConnectDatabase()
        {
            MessageBox.Show("An error occurred while connectdatabase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Input_Successful()
        {
            MessageBox.Show("Add to successful data", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
