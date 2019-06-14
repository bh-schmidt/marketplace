using Marketplace.Infra.CrossCutting.ServiceLocator;

namespace Marketplace.Application.Services.Base
{
    public abstract class BaseAppService
    {
        public T GetInstance<T>()
        {
            return Factory.GetInstance<T>();
        }
    }
}
