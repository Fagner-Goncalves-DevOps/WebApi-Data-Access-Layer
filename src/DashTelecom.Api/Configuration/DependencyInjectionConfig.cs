using DashTelecom.Api.Extensions;
using DashTelecom.Domain.Intefaces;
using DashTelecom.Domain.Notificacoes;
using DashTelecom.Domain.Services;
using DashTelecom.Infrastructure.Context;
using DashTelecom.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DashTelecom.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<ITabTelecomConsolidadoRepository, TabTelecomConsolidadoRepository>();
            services.AddScoped<ICustoGeralRepository, CustoGeralRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}