using Geo.Application.Services;
using Geo.Application.Services.IService;
using Geo.Domain.Interface;
using Geo.Infra.Data.GeoContext;
using Geo.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Geo.Infra.IoC;

public static class IoC
{
    public static IServiceCollection AddIoCServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<Context>(options => options
         .UseNpgsql(config.GetConnectionString("DEV"), x => x
             .MigrationsAssembly(typeof(Context).Assembly.FullName)));

        services.AddScoped<ILocalRepository, LocalRepository>();
        services.AddScoped<ILocalService, LocalServices>();
        return services;
    }
}
