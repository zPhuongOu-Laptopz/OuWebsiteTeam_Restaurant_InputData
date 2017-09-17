using System;
using InputData_BUS.Applications;
using System.Windows.Forms;

namespace InputData_FormUI.MainForm
{
    public partial class Home : Form
    {
        InputData_BUS.Applications.ApplicationServices appservices;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            appservices = new ApplicationServices();
        }

        // Button to logout
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = appservices.ConfirmLogoutApplication();
            if (check == true)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InputData_FormUI.ServicesDatabase.Menu.CategoryMainForm cateform = new ServicesDatabase.Menu.CategoryMainForm();
            cateform.ShowDialog();
            this.Visible = true;
        }
    }
}
