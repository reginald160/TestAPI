using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestAPI.BusinessLogic.DTO;
using TestAPI.Data;
using TestAPI.Domain;

namespace TestAPI.EndPoints.Products
{
    public class ProductEndpoint
    {
   

        public static void  GetProduct(WebApplication app)
        {
            app.MapGroup("ProductMaper/");

            app.MapPost("/Create", async ([FromBody] CreateProductDTO product,
                ApplicationDbContext _dbContext, IMapper _autoMapper) =>
            {
                try
                {
                    var data = _autoMapper.Map<Product>(product);
                    var prod =  await  _dbContext.AddAsync(data);
                    await _dbContext.SaveChangesAsync();
                    return Results.Ok("Record Created");


                }catch(Exception ex)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();

        
        }

        //public static WebApplication GetProduct(WebApplication app)
        //{
        //    var summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //    };

        //    app.MapGet("/weatherforecast", () =>
        //    {
        //        var forecast = Enumerable.Range(1, 5).Select(index =>
        //            new WeatherForecast
        //            (
        //                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //                Random.Shared.Next(-20, 55),
        //                summaries[Random.Shared.Next(summaries.Length)]
        //            ))
        //            .ToArray();
        //        return forecast;
        //    })
        //    .WithName("GetWeatherForecast")
        //    .WithOpenApi();

        //    return app;
        //}


        public static WebApplication GetProductById(WebApplication app)
        {
            app.MapGet("/", () => "Hello World!");

            return app;
        }
    }

}
