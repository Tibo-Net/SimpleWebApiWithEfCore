using Microsoft.EntityFrameworkCore;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
}
