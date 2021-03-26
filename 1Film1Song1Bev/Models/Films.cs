using System;
using System.ComponentModel.DataAnnotations;

namespace _1Film1Song1Beverage.Models
{
    public class Films
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string FilmDescription { get; set; }
    }
}
