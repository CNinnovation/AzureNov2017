using BooksLib.Models;
using System;
using System.Linq;

namespace ManageDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateBooks();
            QueryBooks();

        }

        private static void QueryBooks()
        {
            using (var context = new BooksContext())
            {
                var q = context.Books.Where(b => b.Publisher == "Wrox Press");
                var books = q.ToList();
                foreach (var b in books)
                {
                    Console.WriteLine(b.Title);
                }
            }
        }

        private static void CreateBooks()
        {
            using (var context = new BooksContext())
            {
                context.Books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox Press", Isbn = "34787934" });
                int recordschanged = context.SaveChanges();
                Console.WriteLine($"records changed: {recordschanged}");
            }
        }
    }
}
