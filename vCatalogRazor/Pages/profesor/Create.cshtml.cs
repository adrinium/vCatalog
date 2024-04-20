using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.profesor
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
            return Page();
        }

        [BindProperty]
        public Profesor Profesor { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Profesori.Add(Profesor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
