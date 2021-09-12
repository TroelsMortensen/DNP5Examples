using System;
using System.Collections.Generic;

namespace Examples.Delegates
{
    public class BookExample
    {
        private List<Book> list = new List<Book>()
        {
            new Book
            {
                Title = "First",
                Price = 12.34m
            },
            new Book
            {
                Title = "second",
                Price = 654.34m
            },
        };

        public void RunExample()
        {
            int price = 50;
        }

        private bool Cheaper(Book b, int i)
        {
            return false;
        }
    }
    
    
    internal class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}