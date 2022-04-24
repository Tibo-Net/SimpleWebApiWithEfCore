namespace SimpleWebApiWithEfCore.Model;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public Date DateOfBirth { get; set; }
}

public class Date
{
    public Guid Id { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
}

public enum Gender
{
    Male,
    Female
}