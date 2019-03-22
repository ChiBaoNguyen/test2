using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace WebAPI_MVC.Root.Mappers
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.AddProfile<ViewModelToDomainMappingProfile>();
                mapper.AddProfile<DomainToViewModelMappingProfile>();
            });

        }
    }
}
