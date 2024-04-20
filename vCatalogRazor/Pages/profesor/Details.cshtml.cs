using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.profesor
{
    public class DetailsModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public DetailsModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        public Profesor Profesor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesori.FirstOrDefaultAsync(m => m.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }
            else
            {
                Profesor = profesor;
            }
            return Page();
        }
    }
}
