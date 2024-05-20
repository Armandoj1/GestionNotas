using System;
using System.Data;
using System.Data.SqlClient;

public class DAL_Estudiantes
{
    static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
    SqlConnection connection = new SqlConnection(connectionString);

    public void AgregarEstudiante(string nombre, string CC, DateTime fechaNacimiento, string direccion, string telefono)
    {
        try
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("RegistrarEstudiante", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@CC", CC);
            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Telefono", telefono);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error al agregar el estudiante", ex);
        }
        finally
        {
            connection.Close();
        }
    }
}

