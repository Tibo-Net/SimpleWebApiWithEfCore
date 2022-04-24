using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.DbConfiguration;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.Property(nameof(Person.LastName)).HasMaxLength(100);
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.OwnsOne(x => x.DateOfBirth);
    }
}
