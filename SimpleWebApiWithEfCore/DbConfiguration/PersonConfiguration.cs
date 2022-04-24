using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.DbConfiguration;

public abstract class PersonConfiguration<TPerson> : IEntityTypeConfiguration<TPerson> where TPerson : Person
{
    public void Configure(EntityTypeBuilder<TPerson> builder)
    {
        builder.Property(nameof(Person.LastName)).HasMaxLength(100);
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.OwnsOne(x => x.DateOfBirth);
    }
}

public class StudentConfiguration : PersonConfiguration<Student> { }

public class TeacherConfiguration : PersonConfiguration<Teacher> { }
