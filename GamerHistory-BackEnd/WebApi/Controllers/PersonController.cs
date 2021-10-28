using System.Collections.Generic;
using Domain;
using Infrastructure.SQLServer.PersonSQLServer;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController: ControllerBase
    {
        private IPersonRepository _personRepository;

        [HttpGet]
        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Person> GetById(int id)
        {
            var person = _personRepository.GetById(id);
            if (person != null)
            {
                return StatusCode(200, person);
            }

            return StatusCode(404);
        }

        [HttpPost]
        public Person Create([FromBody] Person person)
        {
            return _personRepository.Create(person.FirstName, person.LastName);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {
            if (_personRepository.Delete(id))
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update(int id, [FromBody] Person person)
        {
            if (_personRepository.Update(id, person))
            {
                return Ok();
            }

            return NotFound();
        }
    }
}