using Microsoft.AspNetCore.Mvc;
using SimpleWebApiWithEfCore.DataAccess;
using SimpleWebApiWithEfCore.Model;

namespace SimpleWebApiWithEfCore.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class PersonController : ControllerBase
{
    protected AppDbContext DbContext { get; private set; }

    public PersonController(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }

    [HttpPost]
    public ActionResult<Person> Add(Person person)
    {
        DbContext.Add(person);
        DbContext.SaveChanges();
        return Ok(person);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Person>> All()
    {
        return Ok(DbContext.Persons.ToList());
    }

    [HttpGet]
    public ActionResult<Person> Get(int id) => DbContext.Persons.FirstOrDefault(p => p.Id == id);

    [HttpDelete]
    public ActionResult Delete(int id)
    {
        var person = DbContext.Persons.FirstOrDefault(x => x.Id == id);
        if (person == null)
        {
            return NotFound();
        }
        DbContext.Persons.Remove(person);
        DbContext.SaveChanges();
        return Ok();
    }
}
