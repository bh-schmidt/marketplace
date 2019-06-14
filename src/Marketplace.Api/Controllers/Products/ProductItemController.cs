using Marketplace.Api.Controllers.Base;
using Marketplace.Domain.Interfaces.Repositories.Products;
using System.Threading.Tasks;
using System.Web.Http;

namespace Marketplace.Api.Controllers.Products
{
    [RoutePrefix("api/ProductItem")]
    public class ProductItemController : BaseController
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IHttpActionResult> GetAll()
        {
            var productItemRepository = GetInstance<IProductItemRepository>();
            return Ok(await productItemRepository.GetAll());
        }

        [HttpGet]
        [Route("GetByCartId/{id}")]
        public async Task<IHttpActionResult> GetByCartId(long id)
        {
            var productItemRepository = GetInstance<IProductItemRepository>();
            return Ok(await productItemRepository.GetByCartId(id));
        }

    }
}
