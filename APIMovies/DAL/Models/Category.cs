using System.ComponentModel.DataAnnotations;

namespace APIMovies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required]
        [Display(Name = "Nombre de la categoría")]
        public string Name { get; set; }
    }
}