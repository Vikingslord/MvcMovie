using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Movie Name")]
        public string Title { get; set; }

        [DisplayName("Release Date")]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }
    }
}
