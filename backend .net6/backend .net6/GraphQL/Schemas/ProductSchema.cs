using backend_.net6.GraphQL.Queries;
using GraphQL.Types;

namespace backend_.net6.GraphQL.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ProductQuery>();
        }
    }
}
