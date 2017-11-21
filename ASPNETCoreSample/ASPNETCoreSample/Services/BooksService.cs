using ASPNETCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreSample.Services
{
    public class BooksService : IBooksService
    {
        public IEnumerable<Book> GetBooks() =>
            Enumerable.Range(1, 20).Select(x => new Book { Id = x, Title = $"title {x}", Publisher = "Sample Pub" });

    }
}
