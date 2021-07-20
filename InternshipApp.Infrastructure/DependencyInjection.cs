using InternshipApp.Core.Common.Interfaces;
using InternshipApp.Core.Services;
using InternshipApp.Domain.Interfaces;
using InternshipApp.Infrastructure.Persistence.Repositories;
using InternshipApp.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InternshipApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        { 
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}