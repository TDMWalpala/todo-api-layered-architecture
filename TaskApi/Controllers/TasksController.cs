using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services.Todos;

namespace TaskApi.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITodoRepository _todoService;

        public TasksController(ITodoRepository repository)
        {
            _todoService =  repository;
        }
        [HttpGet("{id}")]
        public IActionResult GetTodos(int id)
        {
            var allTodos = _todoService.AllTodos().Where(t=>t.Id == id); 
            if (allTodos.Count() == 0)
            {
                return BadRequest();
            }
            return Ok(allTodos);
        }

       

       
    }
}
