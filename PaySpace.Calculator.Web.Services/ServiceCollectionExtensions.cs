using Microsoft.Extensions.DependencyInjection;

using PaySpace.Calculator.Web.Services.Abstractions;

namespace PaySpace.Calculator.Web.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCalculatorHttpServices(this IServiceCollection services)
        {
            services.AddScoped<ICalculatorHttpService, CalculatorHttpService>();
        }
    }
}