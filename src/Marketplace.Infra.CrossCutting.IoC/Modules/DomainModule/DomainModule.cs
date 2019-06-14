using Autofac;
using Marketplace.Domain.Interfaces.Services.Products;
using Marketplace.Domain.Services.Products;

namespace Marketplace.Infra.CrossCutting.IoC.Modules.DomainModule
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductItemService>().As<IProductItemService>();
        }
    }
}
