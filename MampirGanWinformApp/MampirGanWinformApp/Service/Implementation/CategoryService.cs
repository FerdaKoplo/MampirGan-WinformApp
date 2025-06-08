using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Utils;

namespace MampirGanWinformApp.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly LoadCategoryJson _Loader;

        public CategoryService(LoadCategoryJson Loader)
        {
            _Loader = Loader;
            Loader.Load();
        }

        public List<Category> GetAllCategories()
        {
            return _Loader.Categories;
        }
    }
}
