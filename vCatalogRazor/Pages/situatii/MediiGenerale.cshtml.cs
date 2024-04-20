using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace vCatalogRazor.Pages.situatii
{
    public class MediiGeneraleModel : PageModel
    {
        DataTable dt = new DataTable();
        int pid = 0;
        string connectionString = 
            System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void OnGet()
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "select top 1 id from Promotii order by id desc";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                pid = (int)sqlCommand.ExecuteScalar();

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
