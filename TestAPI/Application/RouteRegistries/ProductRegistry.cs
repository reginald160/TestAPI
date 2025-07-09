using TestAPI.EndPoints.Products;

namespace TestAPI.Application.Registry
{
    public static class ProductRegistry
    {
        public static WebApplication RegisterEndpoints(this WebApplication app)
        {

            app.MapGroup("Products/").RequireAuthorization();

            ProductEndpoint.GetProduct(app);
            ProductEndpoint.GetProductById(app);
            
            return app;
        }
    }
}
