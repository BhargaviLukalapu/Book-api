using BookApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace BookApi.Controllers
{
    // https://localhost:7082/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book { Id=1, Author="Author one", Title="Book one"},
            new Book { Id=2, Author="Author Two", Title="Book Two"},
            new Book { Id=3, Author="Author Three", Title="Book Three"}
        };

        [HttpGet]    //endpoint http get
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
