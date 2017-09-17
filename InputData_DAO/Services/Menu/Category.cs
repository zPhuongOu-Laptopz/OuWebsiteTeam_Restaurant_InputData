using System.Data;
using InputData_DAO.DataProvider;
using InputData_DTO.ProjectModels;
using System;
using System.Linq;
using System.Collections.Generic;

namespace InputData_DAO.Services.Menu
{
    public class Category
    {
        InputData_DAO.DataProvider.ConnectDatabase _connect = null;
        InputData_DTO.ProjectModels.RestaurantDBContext _context = null;

        public Category()
        {
            _connect = new ConnectDatabase();
            _context = new RestaurantDBContext();
        }

        public List<InputData_DTO.ProjectModels.Category> GetAllData()
        {
            return _context.Categories.ToList< InputData_DTO.ProjectModels.Category>();
        }

        public bool Create(InputData_DTO.ProjectModels.Category cate)
        {
            _context.Categories.Add(cate);
            _context.Entry(cate).State = System.Data.Entity.EntityState.Added;            
            return _context.SaveChanges() == 1;
        }

        public bool Update(InputData_DTO.ProjectModels.Category cate)
        {
            _context.Categories.Attach(cate);
            _context.Entry(cate).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid ID)
        {
            InputData_DTO.ProjectModels.Category cate = _context.Categories.SingleOrDefault(admin => admin.ID == ID);
            _context.Categories.DefaultIfEmpty(cate);
            _context.Entry(cate).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public InputData_DTO.ProjectModels.Category GetFlowerbyID(Guid id)
        {
            return _context.Categories.SingleOrDefault(fl => fl.ID == id);
        }
    }
}
