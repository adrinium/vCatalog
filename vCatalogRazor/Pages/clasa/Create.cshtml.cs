using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.clasa
{
    public class CreateModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public CreateModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProfesorId"] = new SelectList(_context.Profesori, "Id", "Grad");
        ViewData["PromotieId"] = new SelectList(_context.Promotii, "Id", "Descriere");
            return Page();
        }

        [BindProperty]
        public Clasa Clasa { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clase.Add(Clasa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
