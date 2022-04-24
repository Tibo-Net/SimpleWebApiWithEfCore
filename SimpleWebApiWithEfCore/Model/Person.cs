namespace SimpleWebApiWithEfCore.Model;

public abstract class Person
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
    public ICollection<Course> CoursesFollowed { get; set; }
}

public class Teacher : Person
{
    public Field Field { get; set; }
    public ICollection<Course> CoursesTaught { get; set; }
}

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public ICollection<Student> Students { get; set; }
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