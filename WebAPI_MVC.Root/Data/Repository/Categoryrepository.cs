using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI_MVC.Root.Data.Infrastructure;
using WebAPI_MVC.Root.Model;

namespace WebAPI_MVC.Root.Data.Repository
{
    public class CategoryRepository: RepositoryBase<Category>,ICategoryRepository
    {
        public CategoryRepository(IDatabaseFactory databaseFactory):base(databaseFactory) { }
    }
    public interface ICategoryRepository: IRepository<Category>
    {
    }
}
