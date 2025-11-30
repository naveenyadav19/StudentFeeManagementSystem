using System.Configuration;
using System.Data.SqlClient;

namespace StudentFeeManagement.Core.Data
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["StudentFeeDB"].ConnectionString;
            return new SqlConnection(connString);
        }
    }
}
