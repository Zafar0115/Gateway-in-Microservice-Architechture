using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        IEnumerable<Product> products=new List<Product>()
        {
            new Product(){Name="Dairy"},
            new Product(){Name="Grocery"},
            new Product(){Name="Clothing"},
            new Product(){Name="Household applience"}
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}