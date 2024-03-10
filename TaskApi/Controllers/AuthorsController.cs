using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services.Authors;

namespace TaskApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _repository;
        public AuthorsController(IAuthorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors  = _repository.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id) {

            var author = _repository.GetById(id);
            return Ok(author);
        }
    }
}
