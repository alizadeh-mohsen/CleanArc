using CleanArc.Application.Interfaces;
using CleanArc.Application.Services;
using CleanArc.Domain.Interfaces;
using CleanArc.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<ICourseService, CourseService>();
         
            // Domain
            services.AddScoped<ICourseRepository, CourseRepository>();
            
        }
    }
}
