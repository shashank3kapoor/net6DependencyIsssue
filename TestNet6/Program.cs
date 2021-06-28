using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using TestNet6.Interfaces;
using TestNet6.Services;

namespace TestNet6
{
    class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            var validateInjection = host.Services.GetService<IValidateInjection>();
            validateInjection.PrintEnumeratedValuesToConsole();

            return host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddScoped<Shape, Circle>()
                            .AddScoped<Shape, Cuboid>()
                            .AddScoped<Shape, Rectangle>()
                            .AddScoped<Shape, Sphere>()
                            .AddScoped<Shape, Square>()
                            .AddScoped<Shape, Triangle>()
                            .AddScoped<IValidateInjection, ValidateInjection>()
            );
    }
}
