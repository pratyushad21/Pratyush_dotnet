using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}