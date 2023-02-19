using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _todoService.GetAll();
            return Ok(result);

        }

        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            var result = _todoService.Add(todo);
            return Ok(result);
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var reult = _todoService.GetById(id);
            return Ok(reult);
        }

        [HttpPost]
        public IActionResult Delete(Todo todo)
        {
            var result = _todoService.Delete(todo);
            return Ok(result);
        }
    }
}
