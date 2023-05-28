using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XProject.Application.Configuration;
using XProject.Application.Interfaces;
using XProject.Application.Services;
using XProject.Domain.Interfaces;
using XProject.Infra.Data;
using XProject.Infra.Data.Repositories;

namespace XProject.Infra.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("XProjectDatabase"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IAppPageRepository, ViewRepository>();
            services.AddScoped<IAppPageService, AppPageService>();
            services.AddScoped<IFinantialOperationRepository, FinantialOperationRepository>();
            services.AddScoped<IFinantialOperationService, FinantialOperationService>();

            services.AddAutoMapper(typeof(FinantialOperationProfile));


            return services;
        }
    }
}