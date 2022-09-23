using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        /*bağlantı adresini tanımlayacağız.*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = 192.168.1.203; Database = CoreBlogDb; User ID = cogurcu; Password = deneme; Trusted_Connection = False");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Writer> Writers { get; set; }

        public DbSet<YorumComment> YorumComments { get; set; }

    }
}
