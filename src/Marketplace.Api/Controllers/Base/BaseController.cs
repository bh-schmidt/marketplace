using Marketplace.Infra.CrossCutting.ServiceLocator;
using System.Web.Http;

namespace Marketplace.Api.Controllers.Base
{
    public abstract class BaseController : ApiController
    {
        public T GetInstance<T>()
        {
            return Factory.GetInstance<T>();
        }
    }
}