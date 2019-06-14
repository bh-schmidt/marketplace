using Marketplace.Api.Controllers.Base;
using Marketplace.Domain.Interfaces.Repositories.Products;
using System.Threading.Tasks;
using System.Web.Http;

namespace Marketplace.Api.Controllers.Products
{
    [RoutePrefix("api/Products")]
    public class ProductController : BaseController
    {
        [Route("GetAll")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var productRepository = GetInstance<IProductRepository>();
            return Ok(await productRepository.GetAll());
        }
    }
}
