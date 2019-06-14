using Autofac;
using Marketplace.Application.Interfaces.Products;
using Marketplace.Application.Services.Products;

namespace Marketplace.Infra.CrossCutting.IoC.Modules.ApplicationModule
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductAppService>().As<IProductAppService>();
            builder.RegisterType<ProductItemAppService>().As<IProductItemAppService>();
        }
    }
}
