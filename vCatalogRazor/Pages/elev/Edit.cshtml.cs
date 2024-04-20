using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.elev
{
    public class EditModel : PageModel
    {
        private readonly CatalogDbContext _context;

        public EditModel(CatalogDbContext context)
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
            Elev = elev;
            ViewData["ClasaId"] = new SelectList(_context.Clase, "Id", "Descriere");
            ViewData["PromotieId"] = new SelectList(_context.Promotii, "Id", "Descriere");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Elev).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevExists(Elev.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ElevExists(int id)
        {
            return _context.Elevi.Any(e => e.Id == id);
        }
    }
}
