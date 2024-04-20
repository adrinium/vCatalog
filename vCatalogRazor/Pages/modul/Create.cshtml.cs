using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.modul
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
        ViewData["PromotieId"] = new SelectList(_context.Promotii, "Id", "Descriere");
            return Page();
        }

        [BindProperty]
        public Modul Modul { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Module.Add(Modul);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
