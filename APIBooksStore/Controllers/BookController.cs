using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Core.Entities;
using Store.Core.Services;
using Type = Store.Core.Entities.Type;

namespace APIBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {

        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


 
        // GET: api/<BooksController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.Get());
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_bookService.Get(id));
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _bookService.Post(value);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
           _bookService.Put(id, value);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _bookService.Delete(id);
        }

        [HttpGet("/type")]
        public IActionResult GetByType(Type type)
        {
            return Ok(_bookService.GetByType(type));
        }
    }
}
