using CommonServiceLocator;

namespace Marketplace.Infra.CrossCutting.ServiceLocator
{
    public static class Factory
    {
        public static IServiceLocator ServiceLocator { get; set; }

        public static T GetInstance<T>()
        {
            return ServiceLocator.GetInstance<T>();
        }

    }
}
