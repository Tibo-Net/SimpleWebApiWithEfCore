using Microsoft.EntityFrameworkCore;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=SimpleWebApiWithEfCore;Trusted_Connection=True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().Property<string>(nameof(Person.FirstName)).HasMaxLength(25);
        modelBuilder.Entity<Person>().Property(x => x.LastName).HasMaxLength(25);

        base.OnModelCreating(modelBuilder);
    }
}
