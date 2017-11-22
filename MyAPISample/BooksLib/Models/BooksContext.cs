using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLib.Models
{
    public class BooksContext : DbContext
    {
        // private string ConnectionString = @"use your connection string";
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(ConnectionString);
        //}
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(b => b.Publisher)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
