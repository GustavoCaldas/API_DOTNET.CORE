using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "A", Author = "Arnaldo", PublicationYear = 2020, CallNumber = "123", IsAvailable = true},
            new Book { Id = 2, Title = "b", Author = "Arnaldo", PublicationYear = 2021, CallNumber = "1234", IsAvailable = true},
            new Book { Id = 3, Title = "c", Author = "Arnaldo", PublicationYear = 2022, CallNumber = "12345", IsAvailable = true},
            new Book { Id = 4, Title = "d", Author = "Arnaldo", PublicationYear = 2023, CallNumber = "123456", IsAvailable = true},
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}