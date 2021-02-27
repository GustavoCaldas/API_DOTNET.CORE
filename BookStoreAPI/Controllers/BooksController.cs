using BookStore.Data.Models;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookRepository rep = new BookRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return rep.GetAllBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = rep.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}