using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public enum Genre
    {
        Historical = 1,
        Drama,
        Romance,
        Pyholosphical
    }
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
       
        public double Price { get; set; }
        public Genre genre { get; set; }
    }
}
