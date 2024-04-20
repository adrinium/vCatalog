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
    public class DeleteModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public DeleteModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesori.FindAsync(id);
            if (profesor != null)
            {
                Profesor = profesor;
                _context.Profesori.Remove(Profesor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
