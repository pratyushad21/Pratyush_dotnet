using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection,
        string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options =>
        options.UseSqlite(connection, builder =>
        builder.MigrationsAssembly(migrationsAssembly)));
        
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}