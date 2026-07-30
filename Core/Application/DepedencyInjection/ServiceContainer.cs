using Application.Services.StudentServices;
using Application.Services.ClasssServices;
using Application.Services.FacultyServices;
using Application.Services.EducationLevelServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClasssService, ClasssService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IEducationLevelService, EducationLevelService>();


            return services;
        }
    }
}