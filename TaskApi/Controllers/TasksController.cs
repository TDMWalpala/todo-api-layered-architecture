﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private TodoService _todoService;

        public TasksController()
        {
            _todoService =  new TodoService();
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