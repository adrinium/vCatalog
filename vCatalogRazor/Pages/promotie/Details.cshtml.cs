using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.promotie
{
    public class DetailsModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public DetailsModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        public Promotie Promotie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promotie = await _context.Promotii.FirstOrDefaultAsync(m => m.Id == id);
            if (promotie == null)
            {
                return NotFound();
            }
            else
            {
                Promotie = promotie;
            }
            return Page();
        }
    }
}
