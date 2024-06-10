using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DAL
{
    public class D_GestionDocentes
    {

        public void AgregarDocente(string Nombre, string CC, DateTime FechaNacimiento, string Direccion, int Especialidad, string Telefono, string Correo)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {

                    //Si algún error revisar el orden en que se mandan 
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "AgregarDocente");
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@CC", CC);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@EspecialidadID", Especialidad);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", Correo);


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

        public void ModificarDocente(String CC, string Nombre, DateTime FechaNacimiento, string Direccion, int Especialidad, string Telefono, string Correo)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "ModificarDocente");
                    cmd.Parameters.AddWithValue("@CC", CC);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@EspecialidadID", Especialidad);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", Correo);


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


        public void AgregarEspecialidad(string Especialidad)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "AgregarEspecialidad");
                    cmd.Parameters.AddWithValue("@NombreEspecialidad", Especialidad);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new ApplicationException ("Error: " + ex.Message);
                }

            }

        }
 
        
        public DataTable MostrarDocentes()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarDocentes");

                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public DataTable MostrarDocentesCedula(string CC)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarDocentesCedula");
                    cmd.Parameters.AddWithValue("@CC", CC);
                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public DataTable MostrarDocentesEspecialidad(string Especialidad)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarDocentesEspecialidad");
                    cmd.Parameters.AddWithValue("@EspecialidadID", Especialidad);
                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public void EliminarDocente(string CC)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("GestionarDocentes", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Accion", "EliminarDocente");
                        cmd.Parameters.AddWithValue("@CC", CC);

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int);
                        resultadoParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(resultadoParam);

                        cmd.ExecuteNonQuery();

                        int resultado = (int)cmd.Parameters["@Resultado"].Value;

                        if (resultado == 0)
                        {
                            System.Windows.Forms.MessageBox.Show("El docente tiene materias asignadas y no se puede eliminar.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("¡Datos del docente eliminados!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }


        public DataTable MostrarEspecialidad()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarEspecialidad");
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
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


    }
}
