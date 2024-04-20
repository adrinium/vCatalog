using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.modul
{
    public class DeleteModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public DeleteModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modul Modul { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modul = await _context.Module.FirstOrDefaultAsync(m => m.Id == id);

            if (modul == null)
            {
                return NotFound();
            }
            else
            {
                Modul = modul;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modul = await _context.Module.FindAsync(id);
            if (modul != null)
            {
                Modul = modul;
                _context.Module.Remove(Modul);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
