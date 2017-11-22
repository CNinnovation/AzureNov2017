using System;
using System.Collections.Generic;
using System.Text;
using BooksLib.Models;

namespace BooksLib.Services
{
    public class DbBooksService : IBooksService
    {
        private readonly BooksContext _booksContext;
        public DbBooksService(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }

        public void AddBook(Book book)
        {
            _booksContext.Books.Add(book);
            _booksContext.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = _booksContext.Books;
            return books;
        }
    }
}
