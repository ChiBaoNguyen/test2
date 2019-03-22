using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI_MVC.Root.Data.Infrastructure;
using WebAPI_MVC.Root.Data.Repository;
using WebAPI_MVC.Root.Model;
using WebAPI_MVC.Root.ViewModels;

namespace WebAPI_MVC.Root.Services
{

    public interface ICategoryService
    {
        void CreateClient(CategoryViewModel clientViewModel);
        List<CategoryViewModel> GetListModels();
        void SaveClient();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _clientsRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(ICategoryRepository clientsRepository, IUnitOfWork unitOfWork)
        {
            _clientsRepository = clientsRepository;
            _unitOfWork = unitOfWork;
        }

        public void CreateClient(CategoryViewModel clientViewModel)
        {
            try
            {
                var client = Mapper.Map<CategoryViewModel, Category>(clientViewModel);
                _clientsRepository.Add(client);
                SaveClient();
            }
            catch (Exception ex)
            {
                var aa = ex.Message;
                throw;
            }
        }

        public List<CategoryViewModel> GetListModels()
        {
            var client = _clientsRepository.GetAll();
            if (client != null)
            {
                var result = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(client);
                return result.ToList();
            }
            return null;
        }

        public void SaveClient()
        {
            _unitOfWork.Commit();
        }
    }
}
