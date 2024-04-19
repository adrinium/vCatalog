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

namespace vCatalogRazor.Pages.clasa
{
    public class EditModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public EditModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Clasa Clasa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasa =  await _context.Clase.FirstOrDefaultAsync(m => m.Id == id);
            if (clasa == null)
            {
                return NotFound();
            }
            Clasa = clasa;
           ViewData["ProfesorId"] = new SelectList(_context.Profesori, "Id", "Grad");
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

            _context.Attach(Clasa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClasaExists(Clasa.Id))
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

        private bool ClasaExists(int id)
        {
            return _context.Clase.Any(e => e.Id == id);
        }
    }
}
