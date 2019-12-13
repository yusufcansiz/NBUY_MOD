using NBUY_MOD.DAL.Database;
using NBUY_MOD.Entities;
using NBUY_MOD.Entities.Entity;
using System.Collections.Generic;
using System.Linq;

namespace NBUY_MOD.DAL.Repository
{
    public  class CategoryRepositoryy
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories;
            using (ProjectContext database = new ProjectContext())
            {
                categories = database.Categories.ToList();
            }
            return categories;
        }
    }
}