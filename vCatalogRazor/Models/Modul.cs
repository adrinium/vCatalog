using System.ComponentModel.DataAnnotations;

namespace vCatalogRazor.Models
{
    public class Modul
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Numar { get; set; }
        [Required]
        public string? Nume { get; set; }
        public string? Descriere { get; set; }
        [Required]
        public int IsDeleted { get; set; }
        [Required]
        public int IsActiveInAvg { get; set; }

        // reference navigation
        public int PromotieId { get; set; }
        public Promotie Promotie { get; set; } = null!;

    }
}
