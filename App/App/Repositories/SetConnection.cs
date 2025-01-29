using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Repositories.SetConnection
{
    public class SetConnectionToDatabase
    {
        public static string connectionstring = "data source=DESKTOP-B7H346L; initial catalog=MyDb; integrated security=true; TrustServerCertificate=True";
        public SqlConnection connection = new SqlConnection(connectionstring);
    }
}