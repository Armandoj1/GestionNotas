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


        public void AgregarGrado(string CC, string GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Vincular");
                    cmd.Parameters.AddWithValue("@CC", CC);
                    cmd.Parameters.AddWithValue("@gradoID", GradoID);

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



        public void ModificarGrado(string GradoID, string CC)
        {
            using (SqlConnection connection = Conexion.GetConnection())
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
        }

        public void EliminarEstudianteGrado(string CC)
        {
            using (SqlConnection connection = Conexion.GetConnection())
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
}
