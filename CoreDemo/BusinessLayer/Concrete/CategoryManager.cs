using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    /* bu sayfada koşullar yazılır. hangi koşullar altında crud işlemleri yapılması gerektiği belirlenir.*/
    class CategoryManager : ICategoryService
    {
        CategoryRepository cr = new CategoryRepository();
        public void CategoryAdd(Category category)
        {
            if(category.CategoryName!=""&&category.CategoryDescription!=""&&category.CategoryName.Length>=5&&
                category.CategoryStatus == true)
            {
                cr.AddCategory(category);
            }
            //throw new NotImplementedException();
            else
            {
                //hata mesajı yazılacak.
            }
        }

        public void CategoryDelete(Category category)
        {
            //throw new NotImplementedException();
            cr.DeleteCategory(category);
        }

        public void CategoryUpdate(Category category)
        {
            //throw new NotImplementedException();
            cr.UpdateCategory(category);
        }

        public List<Category> GetList()
        {
            //throw new NotImplementedException();
            cr.ListAllCategory(Category);
        }

        public Category GeyById(int id)
        {
            //throw new NotImplementedException();
            cr.GetById(id);
        }
    }
}
