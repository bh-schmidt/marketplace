using System.Data.Entity.Migrations;

namespace Marketplace.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Marketplace.Infra.Data.Context.MarketplaceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Marketplace.Infra.Data.Context.MarketplaceContext context)
        {
        }
    }
}
