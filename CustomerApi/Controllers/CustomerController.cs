using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
       List<Customer> customers= new List<Customer>()
       {
           new Customer(){Id=1,Name="Ali" },
           new Customer(){Id=2,Name="Vali" },
           new Customer(){Id=3,Name="Tom" },
           new Customer(){Id=4,Name="Thomas" },
       };

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
           return customers;
        }
    }
}