using NBUY_MOD.DAL.Repository;
using NBUY_MOD.Entities;
using NBUY_MOD.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NBUY_MOD.Services
{
    public class CategoryServices
    {
        private readonly CategoryRepositoryy _categoryRepository;
        //private readonly CategoryRepository _categoryRepository;

        public CategoryServices()
        {
            _categoryRepository = new CategoryRepositoryy();
        }

        public List<Category> GetCategories()
        {
            var categories = _categoryRepository.GetAllCategories();

            return categories;
        }
    }
}
