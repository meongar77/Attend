using Application.Services.StudentServices;
using Application.Services.ClasssServices;
using Application.Services.FacultyServices;
using Application.Services.EducationLevelServices;
using Application.Services.RegistrationServices;
using Application.Services.StudentAttendanceServices;
using Application.Services.AttendanceServices;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Domain.Entities;

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
            services.AddScoped<Application.Interfaces.IRegistrationService, RegistrationService>();
            services.AddScoped<IStudentAttendanceService, StudentAttendanceService>();
            services.AddScoped<IAttendanceService, AttendanceService>();


            return services;
        }
    }
}