using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksLib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyAPISample.Controllers
{
    [Route("api/[controller]")]
    public class ManageDBController : Controller
    {
        private readonly BooksContext _booksContext;

        public ManageDBController(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public string CreateDatabase()
        //{
        //    // do not create the database using this method if you use migrations, use Migrate instead!
        //    bool created = _booksContext.Database.EnsureCreated();
        //    return $"database {created} created";
        //}

        [HttpGet]
        public string MigrateDatabase()
        {
            _booksContext.Database.Migrate();
            return "database migrated";
        }
    }
}