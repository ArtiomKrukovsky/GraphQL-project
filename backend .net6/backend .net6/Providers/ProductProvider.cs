using backend_.net6.Models;
using backend_.net6.Providers.Interfaces;

namespace backend_.net6.Providers
{
    public class ProductProvider : IProductProvider
    {
        public List<Product> GetProducts()
        { 
            return new List<Product>
            {
                new Product(1, "Laptop", 20),
                new Product(2, "Mouse", 30),
                new Product(3, "Keyboard", 10),
                new Product(4, "Monitor", 40),
            };
        }
    }
}
