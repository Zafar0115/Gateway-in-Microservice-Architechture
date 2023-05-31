using System.Security.Principal;

namespace CustomerApi
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Cart { get; set; }
    }
}