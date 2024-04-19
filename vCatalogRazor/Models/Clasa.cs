using System.ComponentModel.DataAnnotations;

namespace vCatalogRazor.Models
{
    public class Clasa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nume { get; set; }
        [Required]
        public string? Descriere { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        // reference navigation
        public int PromotieId { get; set; }
        public Promotie Promotie { get; set; } = null!;

        // reference navigation diriginte
        public int? ProfesorId { get; set; }
        public Profesor? Profesor { get; set; }
    }
}
