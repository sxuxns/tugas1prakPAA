using Microsoft.AspNetCore.Mvc;
using TUGAS1PRAKTIKUM.Models;

namespace TUGAS1PRAKTIKUM.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("api/person/{id}")]
        public ActionResult GetPersonById(int id)
        {
            PersonContext context = new PersonContext();
            var person = context.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
    }
}
