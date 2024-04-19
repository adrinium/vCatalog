using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.clasa
{
    public class DetailsModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public DetailsModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        public Clasa Clasa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasa = await _context.Clase.FirstOrDefaultAsync(m => m.Id == id);
            if (clasa == null)
            {
                return NotFound();
            }
            else
            {
                Clasa = clasa;
            }
            return Page();
        }
    }
}
