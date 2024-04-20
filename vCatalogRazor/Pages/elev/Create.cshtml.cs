using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.elev
{
    public class CreateModel : PageModel
    {
        private readonly CatalogDbContext _context;

        public CreateModel(CatalogDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ClasaId"] = new SelectList(_context.Clase, "Id", "Descriere");
            ViewData["PromotieId"] = new SelectList(_context.Promotii, "Id", "Descriere");
            return Page();
        }

        [BindProperty]
        public Elev Elev { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Elevi.Add(Elev);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
