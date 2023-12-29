using backend_.net6.GraphQL.Types;
using backend_.net6.Providers.Interfaces;
using GraphQL.Types;

namespace backend_.net6.GraphQL.Queries
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductProvider productProvider)
        {
            Field<ListGraphType<ProductType>>("products", resolve: x => productProvider.GetProducts());
        }
    }
}
