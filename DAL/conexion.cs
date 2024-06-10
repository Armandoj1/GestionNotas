using System;
using System.Configuration;
using System.Data.SqlClient;



namespace DAL
{
    public class Conexion
    {

            public static SqlConnection GetConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
                return new SqlConnection(connectionString);
            }
        
    }

}

