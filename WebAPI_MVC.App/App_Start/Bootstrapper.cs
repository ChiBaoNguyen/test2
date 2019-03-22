using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_MVC.Root.Mappers;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using WebAPI_MVC.Root.Data.Infrastructure;
using WebAPI_MVC.Root.Data.Repository;
using WebAPI_MVC.Root.Services;

namespace WebAPI_MVC.App.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            AutoMapperConfiguration.Configure();
        }
        public static IContainer SetAutofacContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
            .Where(t => t.Name.EndsWith("Repository"))
            .AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
           .Where(t => t.Name.EndsWith("Service"))
           .AsImplementedInterfaces().InstancePerRequest();

            var container = builder.Build();
            return container;
        }
    }
}