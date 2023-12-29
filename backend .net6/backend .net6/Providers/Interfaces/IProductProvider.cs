using backend_.net6.Models;

namespace backend_.net6.Providers.Interfaces
{
    public interface IProductProvider
    {
        List<Product> GetProducts();
    }
}
