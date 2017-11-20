using System.Collections.Generic;
using ASPNETCoreSample.Models;

namespace ASPNETCoreSample.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
    }
}