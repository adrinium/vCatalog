using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vCatalogRazor.Models
{
    public class Promotie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nume { get; set; }
        [Required]
        public string? Descriere { get; set; }
        public bool IsActive { get; set; }

        //collection navigation
        public ICollection<Clasa> Clase { get; } = new List<Clasa>();
    }
}
