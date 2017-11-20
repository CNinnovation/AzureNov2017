using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreSample.Services;
using ASPNETCoreSample.Models;

namespace ASPNETCoreSample.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AnotherView()
        {
            return View("Index");
        }

        public IActionResult SampleBooks()
        {
            ViewBag.MyData = "Calling from Books";
            // ViewData["MyData"] = "calling from books";
            var books = _booksService.GetBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                Redirect("/Error");
            }
            return $"received book: {book.Id} {book.Title}";
        }
    }
}