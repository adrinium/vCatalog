using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.clasa
{
    public class IndexModel : PageModel
    {
        private readonly vCatalogRazor.Data.CatalogDbContext _context;

        public IndexModel(vCatalogRazor.Data.CatalogDbContext context)
        {
            _context = context;
        }

        public IList<Clasa> Clasa { get;set; } = default!;

        public async Task OnGetAsync()
        {
            
            Clasa = await _context.Clase
                .Include(c => c.Profesor)
                .Include(c => c.Promotie).ToListAsync();
        }
    }
}
