using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Data;
using vCatalogRazor.Models;

namespace vCatalogRazor.Pages.profesor
{
    public class IndexModel : PageModel
    {
        private readonly CatalogDbContext _context;

        public IndexModel(CatalogDbContext context)
        {
            _context = context;
        }

        public IList<Profesor> ProfesoriList { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ProfesoriList = await _context.Profesori.ToListAsync();
        }
    }
}
