using System;
using System.Data.SqlClient;



namespace DAL
{
    public class Conexion
    {
        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool Conectar()
        {
            try
            {
                connection.Open();
                return true; // Devuelve true si la conexión fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false; // Devuelve false si hubo un error en la conexión
            }
        }


    }
}
