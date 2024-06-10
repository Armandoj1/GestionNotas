    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class D_Grados
    {
      
        public DataTable ListarGrados()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GestionarAlumnos", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Accion", "MostrarGrados");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los grados: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }


        public void VincularGrado(string EstudianteID, int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Vincular");
                    cmd.Parameters.AddWithValue("@EstudianteCC", EstudianteID);
                    cmd.Parameters.AddWithValue("@GradoID", GradoID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }



        public void Modificar(int GradoID, string NombreGrado)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "CambiarNombreGrado");
                    cmd.Parameters.AddWithValue("@GradoID", GradoID);
                    cmd.Parameters.AddWithValue("@NombreGrado", NombreGrado);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        // Si el error es debido a violación de restricción de unicidad
                        MessageBox.Show("El nombre del grado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si es otro tipo de error de SQL
                        throw new ApplicationException("Error al modificar el nombre del grado: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al modificar el nombre del grado: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open) { connection.Close(); }
                }
            }
        }


        public void CambiarNombreGrado(string NombreGrado, int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "CambiarNombreGrado");
                    cmd.Parameters.AddWithValue("@NombreGrado", NombreGrado);
                    cmd.Parameters.AddWithValue("@GradoID", GradoID);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    int resultado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    if (resultado == 0)
                    {
                        throw new Exception("El nombre del grado ya existe.");
                    }
                    else
                    {
                        MessageBox.Show("¡Grado modificado con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al modificar el nombre del grado: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public DataTable MostrarModificar()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarConGrados");
                    SqlDataAdapter tabla = new SqlDataAdapter(cmd);
                    DataTable datos = new DataTable();
                    tabla.Fill(datos);
                    return datos;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error" + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open) { connection.Close(); }

                }
            }
        }

        public void AgregarGrado(string NombreGrado)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Agregar");
                    cmd.Parameters.AddWithValue("@NombreGrado", NombreGrado);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    int resultado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    if (resultado == 0)
                    {
                        throw new Exception("El nombre del grado ya existe.");
                    }
                    else
                    {
                        MessageBox.Show("¡Grado creado con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al agregar el grado: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    





    public DataTable MostrarGrados()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarGrados");
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public DataTable MostrarEstudiantes()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Mostrar");
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    return dataTable;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

        }


        public void EliminarEstudianteGrado(string EstudianteCC)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Desvincular");
                    cmd.Parameters.AddWithValue("@EstudianteCC", EstudianteCC);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }




    }
}
