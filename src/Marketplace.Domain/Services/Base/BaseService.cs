using Marketplace.Infra.CrossCutting.ServiceLocator;

namespace Marketplace.Domain.Services.Base
{
    public abstract class BaseService
    {
        public T GetInstance<T>()
        {
            return Factory.GetInstance<T>();
        }
    }
}
