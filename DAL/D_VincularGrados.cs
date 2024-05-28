using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_VincularGrados
    {

        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);

        public void AgregarGrado(string CC, string GradoID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Vincular");
                cmd.Parameters.AddWithValue("@CC", CC);
                cmd.Parameters.AddWithValue("@NombreGrado", GradoID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }




        public void ModificarGrado(string GradoID, string CC)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Modificar");
                cmd.Parameters.AddWithValue("@GradoID", GradoID);
                cmd.Parameters.AddWithValue("@CC", CC);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public void EliminarEstudianteGrado(string CC)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("EliminarEstudianteGrado", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CC", CC);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
