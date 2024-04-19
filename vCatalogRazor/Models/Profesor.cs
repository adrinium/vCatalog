using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace vCatalogRazor.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Grad { get; set; }
        [Required]
        public string? Nume { get; set; }
        [Required]
        public string? Prenume { get; set; }
        public string? Functie { get; set; }
        [AllowNull]
        public DateOnly DataAngajare { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        //collection navigation
        public ICollection<Clasa> Clase { get; } = new List<Clasa>();
    }
}
