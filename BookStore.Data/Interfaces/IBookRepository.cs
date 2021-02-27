using BookStore.Data.Models;
using System.Collections.Generic;

namespace BookStore.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        Book GetBook(int id);
    }
}