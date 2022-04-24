using Microsoft.EntityFrameworkCore;
using SimpleWebApiWithEfCore.DbConfiguration;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfiguration).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties(typeof(Enum)).HaveConversion<string>().HaveMaxLength(50);
        base.ConfigureConventions(configurationBuilder);
    }
}
