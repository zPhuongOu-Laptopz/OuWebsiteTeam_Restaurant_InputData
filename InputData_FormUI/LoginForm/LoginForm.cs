using System;
using System.Windows.Forms;
using InputData_DTO.Models;
using InputData_BUS.Applications;
using InputData_BUS.Login;

namespace InputData_FormUI.LoginForm
{
    public partial class LoginForm : Form
    {
        //variable
        InputData_DTO.Models.UserLogin ustest;
        InputData_FormUI.MainForm.Home homepage;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ustest = new UserLogin("admin", "123", true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienmatkhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        //Button to Login       
        private void button2_Click(object sender, EventArgs e)
        {
            txtstatus.Text = new InputData_BUS.Login.LoginServices { }.RequestLogin(ustest, txttaikhoan.Text, txtmatkhau.Text);
            if (txtstatus.Text == "Login Success")
            {
                homepage = new MainForm.Home();
                txttaikhoan.Text = "admin";
                txtmatkhau.Text = "";
                this.Visible = false;
                homepage.ShowDialog();
                this.Visible = true;
                txtstatus.Text = "Logout Success - Ready to Login";
            }
        }

        //Button to Exit
        private void button1_Click(object sender, EventArgs e)
        {
            txtstatus.Text = new InputData_BUS.Applications.ApplicationServices { }.ConfirmExitApplication();
        }
    }
}
