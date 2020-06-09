
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using AutoMapper;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Esmart.Application.WebApi.Modules;
using Esmart.Infrastructure.Data;


namespace Esmart.Application.WebApi.IOC
{
    public class IOCConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            

            #region AutoMapper
            builder.RegisterModule(new AutoMapperModule());

          
            //builder.RegisterAssemblyTypes().AssignableTo(typeof(Profile)).As<Profile>();
            //builder.Register(c => new MapperConfiguration(cfg =>
            //{
            //    foreach (var profile in c.Resolve<IEnumerable<Profile>>())
            //    {
            //        cfg.AddProfile(profile);
            //    }
            //    cfg.AllowNullCollections = true;
            //})).AsSelf().SingleInstance();
            //builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

    

            #endregion


            builder.RegisterType<esmartEntities>().InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Application.Services"))
                .Where(t => t.Name.EndsWith("ApplicationService"))
                .AsImplementedInterfaces()
               .InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Domain.Services"))
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces()
              .InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Infrastructure.Repository"))
                  .Where(t => t.Name.EndsWith("Repository"))
                  .AsImplementedInterfaces()
                 .InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Infrastructure.EmailUtility"))
                  .Where(t => t.Name.EndsWith("UtilityService"))
                  .AsImplementedInterfaces()
                 .InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Infrastructure.Utilities"))
                 .Where(t => t.Name.EndsWith("Service"))
                 .AsImplementedInterfaces()
                .InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Infrastructure.Common"))
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
               .InstancePerRequest();

            //builder.RegisterAssemblyTypes(Assembly.Load("Esmart.Infrastructure.Utilities.Service"))
            //     .Where(t => t.Name.EndsWith("Service"))
            //     .AsImplementedInterfaces()
            //    .InstancePerRequest();
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            //builder.RegisterType<ApplicationOAuthProvider>().WithParameter("publicClientId", "self");

            var container = builder.Build();


            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
			

		}
    }
}