using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using vCatalogRazor.Data;

namespace vCatalogRazor.Pages.situatii
{
    public class MediiGeneraleModel : PageModel
    {
        private readonly IConfiguration Configuration;
        private readonly string? connectionString;
        private readonly CatalogDbContext _context;

        public DataTable dt = new DataTable();

        int pid = 0;


        [BindProperty]
        public string selectedFilter { get; set; }
        public SelectList Promotii { get; set; }

        public MediiGeneraleModel(IConfiguration configuration, CatalogDbContext context)
        {
            Configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            _context = context;
            Promotii = new SelectList(_context.Promotii.OrderByDescending(p => p.Nume), "Id", "Nume");
        }

        public void OnGet()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "select top 1 id from Promotii order by id desc";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                pid = (int)sqlCommand.ExecuteScalar();
                pid = 5;

                SqlCommand sqlCommandSP = new SqlCommand("sp_GetMediiGenerale", sqlConnection);
                sqlCommandSP.CommandType = CommandType.StoredProcedure;
                SqlParameter promotieId = new SqlParameter("@PromotieId", pid);
                sqlCommandSP.Parameters.Add(promotieId);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandSP);
                sqlDataAdapter.Fill(dt);
            }
        }
    }
}
