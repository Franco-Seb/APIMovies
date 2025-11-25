using System.ComponentModel.DataAnnotations;

namespace APIMovies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }

        public string? Description { get; set; }

        [Required]
        public string Clasification { get; set; }
    }
}   
