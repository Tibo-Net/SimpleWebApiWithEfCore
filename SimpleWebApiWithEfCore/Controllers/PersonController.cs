using Microsoft.AspNetCore.Mvc;
using SimpleWebApiWithEfCore.DataAccess;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.Controllers;

public class StudentController : PersonController<Student>
{
    public StudentController(AppDbContext dbContext) : base(dbContext)
    {
    }
}

public class TeacherController : PersonController<Teacher>
{
    public TeacherController(AppDbContext dbContext) : base(dbContext)
    {
    }
}

[ApiController]
[Route("[controller]/[Action]")]
public abstract class PersonController<TPerson> : ControllerBase where TPerson : Person
{
    protected AppDbContext DbContext { get; private set; }

    public PersonController(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }

    [HttpPost]
    public ActionResult<Person> Add(TPerson person)
    {
        DbContext.Add(person);
        DbContext.SaveChanges();
        return Ok(person);
    }

    [HttpGet]
    public ActionResult<IEnumerable<TPerson>> All()
    {
        return Ok(DbContext.Set<TPerson>().ToList());
    }

    [HttpGet]
    public ActionResult<IEnumerable<Person>> AllByGender(Gender gender)
    {
        return Ok(DbContext.Set<TPerson>().Where(x => x.Gender == gender).ToList());
    }

    [HttpGet]
    public ActionResult<Person> Get(int id) => DbContext.Set<TPerson>().FirstOrDefault(p => p.Id == id);

    [HttpDelete]
    public ActionResult Delete(int id)
    {
        var person = DbContext.Set<TPerson>().FirstOrDefault(x => x.Id == id);
        if (person == null)
        {
            return NotFound();
        }
        DbContext.Set<TPerson>().Remove(person);
        DbContext.SaveChanges();
        return Ok();
    }
}
