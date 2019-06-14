using Autofac;
using Marketplace.Domain.Interfaces.Repositories.Products;
using Marketplace.Infra.Data.Repositories.Products;

namespace Marketplace.Infra.CrossCutting.IoC.Modules.DataModule
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductItemRepository>().As<IProductItemRepository>();
        }
    }
}
