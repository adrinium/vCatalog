using System.ComponentModel.DataAnnotations;

namespace vCatalogRazor.Models
{
    public class TipNota
    {
        [Key]
        public int Id { get; set; }
        public string? Nume { get; set; }
        public string? Acronim { get; set; }

    }
}
