using CleanArc.Application.Interfaces;
using CleanArc.Application.Services;
using CleanArc.Domain.CommandHandlers;
using CleanArc.Domain.Commands;
using CleanArc.Domain.Core.Bus;
using CleanArc.Domain.Interfaces;
using CleanArc.Infra.Bus;
using CleanArc.Infra.Data.Context;
using CleanArc.Infra.Data.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();


            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();



        }
    }
}
