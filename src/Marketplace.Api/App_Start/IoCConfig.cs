using Autofac;
using Autofac.Integration.WebApi;
using Marketplace.Infra.CrossCutting.IoC.Modules.ApplicationModule;
using Marketplace.Infra.CrossCutting.IoC.Modules.DataModule;
using Marketplace.Infra.CrossCutting.IoC.Modules.DomainModule;
using System.Reflection;
using System.Web.Http;

namespace Marketplace.Api.App_Start
{
    public class IoCConfig
    {
        public IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();

            RegisterModules(builder);

            return builder.Build();
        }

        private void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule(new ApplicationModule());
            builder.RegisterModule(new DomainModule());
            builder.RegisterModule(new DataModule());
        }
    }
}