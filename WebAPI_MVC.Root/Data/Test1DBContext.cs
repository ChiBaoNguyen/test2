using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Threading.Tasks;
using WebAPI_MVC.Root.Model;
using WebAPI_MVC.Root.Model.Mapping;

namespace WebAPI_MVC.Root.Data
{
    public class Test1DBContext : DbContext
    {
        public Test1DBContext()
        : base("Name=Test1DBContext") // false: giam 2 giay
        {
        }

        public DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            base.OnModelCreating(modelBuilder);
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }

}
