using Geo.Application.Mappings;
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
        var connectionString = config["ConnectionStrings:DefaultConnection"];

        if (string.IsNullOrEmpty(connectionString))
        {
            connectionString = config.GetConnectionString("DEV");
        }
        services.AddDbContext<Context>(options => options
            .UseNpgsql(connectionString, x => x
                .UseNetTopologySuite()
                .MigrationsAssembly(typeof(Context).Assembly.FullName)));

        services.AddScoped<ILocalRepository, LocalRepository>();
        services.AddScoped<ILocalService, LocalServices>();

        services.AddAutoMapper(typeof(Mapping));

        return services;
    }
}
