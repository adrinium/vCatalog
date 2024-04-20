using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.DTO;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.elev
{
    public class IndexModel : PageModel
    {
        private readonly CatalogDbContext _context;

        public IndexModel(CatalogDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ElevDTO> Elev { get;set; } = default!;

        public void OnGet()
        {
            //Elev = await _context.Elevi
            //    .Include(e => e.Clasa)
            //    .Include(e => e.Promotie).ToListAsync();
            Elev = _context.Elevi
                .Select(e => new ElevDTO
                {
                    Id = e.Id,
                    Nume = e.Nume,
                    Prenume = e.Prenume,
                    PrenumeTata = e.PrenumeTata,
                    Promotie = e.Promotie.Nume,
                    Clasa = e.Clasa.Nume
                });
        }
    }
}
