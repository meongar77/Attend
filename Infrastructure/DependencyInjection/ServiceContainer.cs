using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Repositories;
namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            

            // Add infrastructure services here, e.g., DbContext, Repositories, etc.

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ATTENDCON"))
            );
            services.AddScoped<IStudent, StudentRepository>();
            
            return services;

        }
    }
}