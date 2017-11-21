using BooksLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksLib.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books;
        public BooksService()
        {
            _books = Enumerable.Range(1, 20).Select(x => new Book
            { BookId = x, Title = $"title {x}", Publisher = "Sample Pub" }).ToList();
        }

        public IEnumerable<Book> GetAllBooks() => _books;

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}
