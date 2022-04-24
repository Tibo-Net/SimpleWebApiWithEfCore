using Microsoft.EntityFrameworkCore;
using SimpleWebApiWithEfCore.DbConfiguration;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfiguration<>).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties(typeof(Enum)).HaveConversion<string>().HaveMaxLength(50);
        base.ConfigureConventions(configurationBuilder);
    }
}
