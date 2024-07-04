using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class D_Usuarios
    {

        public void ValidarUsuario(string Usuario, string Password, string Rol)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarUsuarios", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "ValidarUsuario"); // Asegúrate de que el valor coincida con lo esperado en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Rol", Rol); // Agregar el parámetro del rol
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    var resultado = cmd.Parameters["@Resultado"].Value;
                    if (resultado != DBNull.Value)
                    {
                        int resultadoInt = Convert.ToInt32(resultado);
                        switch (resultadoInt)
                        {
                            case 0:
                                throw new Exception("¡Usuario o contraseña incorrecta!");
                            case 1:
                                MessageBox.Show("¡Bienvenido " + Usuario + "! Se iniciará la sesión", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 3:
                                throw new Exception("¡El rol es incorrecto para el usuario!");
                            default:
                                throw new Exception("Error desconocido al validar el usuario.");
                        }
                    }
                    else
                    {
                        throw new Exception("Resultado devuelto es NULL.");
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al validar el usuario. Detalle: " + ex.Message, ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }


        public DataTable MostarRoles()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarUsuarios", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "ListarRoles");

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al consultar los roles." + ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public DataTable ValidarUsuarioDocente(string Usuario)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarUsuarios", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "EsDocente");
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    datos.Fill(dataTable);
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
