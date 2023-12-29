using backend_.net6.Models;
using GraphQL.Types;

namespace backend_.net6.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(product => product.Id);
            Field(product => product.Name);
            Field(product => product.Quantity);
        }
    }
}
