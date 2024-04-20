using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vCatalogRazor.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal Valoare { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataAcordare { get; set; }

        public int TipNotaId { get; set; }
        public TipNota TipNota { get; set; } = null!;

        public int ElevId { get; set; }
        public Elev Elev { get; set; } = null!;

        public int ModulId { get; set; }
        public Modul Modul { get; set; } = null!;

        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; } = null!;

        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string? ModifiedBy { get; set; }
        public bool NotShowLate { get; set; }
    }
}
