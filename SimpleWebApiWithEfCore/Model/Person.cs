namespace SimpleWebApiWithEfCore.Model;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public Date DateOfBirth { get; set; }
}

public class Student : Person
{
    public Year Year { get; set; }
}

public class Teacher : Person
{
    public Field Field { get; set; }
}

public class Date
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
}

public enum Field
{
    ObjectOrientedProgrammation,
    FunctionalProgrammation,
    RelationalDataBase,
    NoSqlDataBase,
    Finance
}

public enum Year
{
    First,
    Second,
    Third
}

public enum Gender
{
    Male,
    Female
}