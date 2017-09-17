using System;
using System.Data;
using InputData_DTO.ProjectModels;
using InputData_BUS.Applications;
using InputData_BUS.Menu;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InputData_FormUI.ServicesDatabase.Menu
{
    public partial class CategoryMainForm : Form
    {
        Guid a;
        InputData_BUS.Applications.ApplicationServices services;        
        public CategoryMainForm()
        {
            InitializeComponent();
        }

        private void CategoryMainForm_Load(object sender, EventArgs e)
        {
            services = new ApplicationServices();
            a = Guid.NewGuid();
            createby.Items.Add(a);
            modifyby.Items.Add(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<InputData_DTO.ProjectModels.Category> list = new InputData_BUS.Menu.CategoryServices { }.GetAllData();
            gridview.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InputData_DTO.ProjectModels.Category cate = new Category();
                cate.ID = Guid.NewGuid();
                cate.Name = txtname.Text;
                cate.CreatedDate = createdate.Value;
                cate.CreatedBy = a;
                cate.ModifiedDate = modifydate.Value;
                cate.Modifedby = a;
                cate.Filter = Convert.ToInt32(txtfilter.Text);
                cate.HtmlIcon = txthtmlcode.Text;
                if (status.SelectedIndex == 0)
                {
                    cate.IsStatus = true;
                }
                else
                {
                    cate.IsStatus = false;
                }
                bool check = new InputData_BUS.Menu.CategoryServices { }.Create(cate);
                if (check == true)
                {
                    services.Input_Successful();
                    lb_newid.Text = cate.ID.ToString();
                }
            }
            catch
            {
                services.ErrorWhileProcessing();
            }
        }
    }
}
