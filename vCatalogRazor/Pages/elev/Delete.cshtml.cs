using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.elev
{
    public class DeleteModel : PageModel
    {
        private readonly CatalogDbContext _context;

        public DeleteModel(CatalogDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Elev Elev { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elev = await _context.Elevi.FirstOrDefaultAsync(m => m.Id == id);

            if (elev == null)
            {
                return NotFound();
            }
            else
            {
                Elev = elev;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elev = await _context.Elevi.FindAsync(id);
            if (elev != null)
            {
                Elev = elev;
                _context.Elevi.Remove(Elev);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
