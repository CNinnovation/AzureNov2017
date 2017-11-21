using System.Collections.Generic;
using BooksLib.Models;

namespace BooksLib.Services
{
    public interface IBooksService
    {
        void AddBook(Book book);
        IEnumerable<Book> GetAllBooks();
    }
}