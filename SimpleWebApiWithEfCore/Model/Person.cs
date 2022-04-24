using System.ComponentModel.DataAnnotations;

namespace SimpleWebApiWithEfCore.Model;

public class Person
{
    public int Id { get; set; }
    [MaxLength(50)] public string FirstName { get; set; }
    [MaxLength(50)] public string LastName { get; set; }
}
