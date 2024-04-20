using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vCatalogRazor.Models
{
    public class Elev
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nume { get; set; }
        [Required]
        public string? Prenume { get; set; }
        public string? PrenumeTata { get; set; }
        public string? PrenumeMama { get; set; }
        [Required]
        [Length(13, 13)]
        public string? CNP { get; set; }
        public string? SerieNumarCI { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? DataNastere { get; set; }
        public string? LocNastere { get; set; }
        public string? Etnie { get; set; }
        public string? Sex { get; set; }
        public string? StareCivila { get; set; }
        public string? TelefonMobil { get; set; }
        public string? TelefonFix { get; set; }
        public string? Email { get; set; }
        public Byte[]? Fotografie { get; set; }
        public string? AdresaStrada { get; set; }
        public string? AdresaNumar { get; set; }
        public string? AdresaBloc { get; set; }
        public string? AdresaScara { get; set; }
        public string? AdresaEtaj { get; set; }
        public string? AdresaApartament { get; set; }
        public string? AdresaLocalitate { get; set; }
        public string? AdresaJudet { get; set; }
        public string? NumarMatricol { get; set; }
        public string? CodBiblioteca { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool IsDeleted { get; set; } = false;

        //reference navigation
        public int PromotieId { get; set; }
        public Promotie Promotie { get; set; } = null!;

        //reference navigation
        public int? ClasaId { get; set; }
        public Clasa? Clasa { get; set; }

        //collection navigation
        public ICollection<Nota> Note { get; set; } = new List<Nota>();


    }
}
