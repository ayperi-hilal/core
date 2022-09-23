using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();

        public void AddCategory(Category category)
        {
            //throw new NotImplementedException();
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            //throw new NotImplementedException();
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            //throw new NotImplementedException();
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            //throw new NotImplementedException();
            return c.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            //throw new NotImplementedException();

            c.Update(category);
            c.SaveChanges();
        }
    }
}
