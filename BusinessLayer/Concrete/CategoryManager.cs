using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
        
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            categoryDal.Insert(category);

        }

        public void CategoryRemove(Category category)
        {
            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
           categoryDal.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return categoryDal.GetListAll();
        }

        public Category GetCategoryById(int id)
        {
            return categoryDal.Get(id);
        }
    }
}
