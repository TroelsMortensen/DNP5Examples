using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncludeExample.DataAccess;
using IncludeExample.Models;
using Microsoft.EntityFrameworkCore;

namespace IncludeExample
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            //SetupDB();
            using AuthorContext ac = new AuthorContext();
            List<Author> authors = ac.Authors.
                Where(a => a.Id == 1).
                Include(a => a.Books).
                ThenInclude(b => b.Genres).
                Include(a => a.Address)
                .ToList();
            int stophere = 0;
        }

        private static void SetupDB()
        {
            Genre fantasy = new Genre
            {
                Name = "Fantasy"
            };

            Genre urban = new Genre
            {
                Name = "Urban"
            };

            Genre superheroes = new Genre
            {
                Name = "Superheroes"
            };

            Genre scifi = new Genre
            {
                Name = "Scifi"
            };

            Genre magic = new Genre
            {
                Name = "Magic"
            };


            Book b1 = new()
            {
                Title = "Rythm of War",
                PageCount = 1232,
                PublicationYear = 2020,
                ISBN = "0765326388",
                Genres = new List<Genre> {fantasy, magic}
            };

            Book b2 = new()
            {
                Title = "The Alloy of Law",
                PageCount = 332,
                PublicationYear = 2011,
                ISBN = "0765330423",
                Genres = new List<Genre> {urban, fantasy, magic}
            };
            Book b3 = new()
            {
                Title = "Steelheart",
                PageCount = 386,
                PublicationYear = 2013,
                ISBN = "0385743564",
                Genres = new List<Genre> {superheroes, urban, scifi}
            };
            Book b4 = new()
            {
                Title = "Judgment of Mars",
                PageCount = 270,
                PublicationYear = 2017,
                ISBN = "34538192",
                Genres = new List<Genre> {scifi, fantasy, magic}
            };
            Book b5 = new()
            {
                Title = "Blood of the Innocent",
                PageCount = 322,
                PublicationYear = 2017,
                ISBN = "35823660",
                Genres = new List<Genre> {urban, fantasy}
            };

            Author brandon = new Author
            {
                FirstName = "Brandon",
                LastName = "Sanderson",
                Address = new()
                {
                    Street = "Nowhere",
                    HouseNumber = 3,
                    PostCode = 837
                },
                Books = new List<Book> {b1, b2, b3}
            };

            Author glynn = new Author
            {
                FirstName = "Glynn",
                LastName = "Stewart",
                Address = new()
                {
                    Street = "Anywhere",
                    HouseNumber = 7,
                    PostCode = 824
                },
                Books = new List<Book> {b4, b5}
            };

            using AuthorContext ac = new AuthorContext();
            ac.Add(brandon);
            ac.Add(glynn);
            ac.SaveChanges();
        }
    }
}