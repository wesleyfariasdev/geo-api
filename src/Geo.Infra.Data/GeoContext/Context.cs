using Geo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Geo.Infra.Data.GeoContext;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Local> Locais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    }
}
