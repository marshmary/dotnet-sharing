using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        public BooksController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}