using Microsoft.Data.SqlClient;

namespace Shop.DL
{
    public  static class Helper
    {
        private static string connection = @"Integrated Security=SSPI;
                           Persist Security Info=False;
                           Initial Catalog=Practices;
                           Data Source=(LocalDB)\MSSQLLocalDB;
                           Encrypt=False;";
        public static int Register(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return 1;


        }
        
    }
}
