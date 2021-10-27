using System.Collections.Generic;
using Domain;
using Infrastructure.SQLServer.TodoSQLServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController: ControllerBase
    {
        private ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        public List<Todo> GetALl()
        {
            return _todoRepository.GetAll();
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Todo> GetById(int id)
        {
            var todo = _todoRepository.GetById(id);
            if (todo != null)
            {
                return StatusCode(200, todo);
            }

            return StatusCode(404);
        }

        [HttpPost]
        public Todo Create([FromBody] Todo todo)
        {
            return _todoRepository.Create(todo.Title);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {
            if (_todoRepository.Delete(id))
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update(int id, [FromBody] Todo todo)
        {
            if (_todoRepository.Update(id, todo))
            {
                return Ok();
            }

            return NotFound();
        }
    }
}