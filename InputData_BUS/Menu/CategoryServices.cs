using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using InputData_DAO.Services.Menu;

namespace InputData_BUS.Menu
{
    public class CategoryServices
    {
        public List<InputData_DTO.ProjectModels.Category> GetAllData()
        {
            return new InputData_DAO.Services.Menu.Category { }.GetAllData();
        }

        public bool Create (InputData_DTO.ProjectModels.Category cate)
        {
            if (cate.Name == "")
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cate.CreatedBy == Guid.Empty)
            {
                MessageBox.Show("CreatedBy is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cate.Filter == 0)
            {
                MessageBox.Show("Filter is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cate.HtmlIcon == "")
            {
                MessageBox.Show("HtmlIcon is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return new InputData_DAO.Services.Menu.Category { }.Create(cate);
            }            
        }
    }
}
