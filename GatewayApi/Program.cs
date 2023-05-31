using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace GatewayApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddOcelot();
            builder.Configuration.AddJsonFile("configuration.json");


            var app = builder.Build();
            
            app.UseRouting();
           
                app.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Gateway Api Started");
                });

            app.UseOcelot();
            app.Run();
        }
    }
}