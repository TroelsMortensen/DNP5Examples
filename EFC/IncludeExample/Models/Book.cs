using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IncludeExample.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int PageCount { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}