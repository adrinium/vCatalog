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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? DataAngajare { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        //collection navigation
        public ICollection<Clasa> Clase { get; } = new List<Clasa>();

        public ICollection<Nota> Note { get; set; } = new List<Nota>();
    }
}
