using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI_MVC.Root.Model;
using WebAPI_MVC.Root.ViewModels;

namespace WebAPI_MVC.Root.Mappers
{
    class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappingProfile";
            }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Category, CategoryViewModel>();
        }
    }
}
