using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace PRESENTACION
{
    public partial class FrmEstudiantes : Form
    {
        B_Estudiantescs BLL = new B_Estudiantescs();
        E_Estudiantes estudiante = new E_Estudiantes();

        public void MostrarDgv()
        {
            dataGridView1.DataSource = BLL.ConsultarEstudiantes();
            this.FormatoEstudiantes();

        }


        public void FormatoEstudiantes()
        {
            dataGridView1.Columns[0].HeaderText = "Cédula";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].HeaderText = "Fecha de nacimiento";
            dataGridView1.Columns[3].HeaderText = "Dirección";
            dataGridView1.Columns[4].HeaderText = "Teléfono";
            dataGridView1.Columns[5].HeaderText = "Grado";
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].HeaderText = "Fecha de inclusión";
            dataGridView1.Columns[6].Width = 90;

        }
     

        public FrmEstudiantes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            MostrarDgv();

        }
        #region "Controles de textbox"



        void Limpiar()
        {
            TxtTelefono.Text = "";
            TxtCC.Text = "";
            TxtDireccion.Text = "";
            TxtNombreCompleto.Text = "";
            PickerNacimiento.Text = "";
        }
        
        
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (TxtTelefono.Text.Length > 10)
            {
                TxtTelefono.Text = TxtTelefono.Text.Substring(0, 10);
                TxtTelefono.SelectionStart = TxtTelefono.Text.Length;
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text.Length > 10)
            {

                MessageBox.Show("El número de celular no puede exceder 10 números.");
                TxtTelefono.Focus();

            }

        }


        private void TxtCC_TextChanged(object sender, EventArgs e)
        {
            if (TxtCC.Text.Length > 10)
            {
                TxtCC.Text = TxtCC.Text.Substring(0, 10);
                TxtCC.SelectionStart = TxtCC.Text.Length;
            }
            

        }

        private void TxtCC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TxtCC_Leave(object sender, EventArgs e)
        {
            if(TxtCC.Text.Length > 10)
            {
                MessageBox.Show("La cédula no puede exceder los 10 caracteres.");
                TxtCC.Focus();
            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtCC.Enabled = false;
            // Verifica que la fila clickeada no es una fila de encabezado
            if (dataGridView1.RowCount > 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extrae los valores de las celdas
                string nombre = row.Cells["NombreCompleto"].Value.ToString();
                string cc = row.Cells["CC"].Value.ToString();
                string fechaNacimiento = row.Cells["FechaNacimiento"].Value.ToString();
                string direccion = row.Cells["Direccion"].Value.ToString();
                string telefono = row.Cells["Telefono"].Value.ToString();

                // Asigna los valores a los controles correspondientes
                TxtNombreCompleto.Text = nombre;
                TxtCC.Text = cc;
                PickerNacimiento.Value = DateTime.Parse(fechaNacimiento); 
                TxtDireccion.Text = direccion;
                TxtTelefono.Text = telefono;
            }
        }


        #endregion


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {

        }


        #region "Procedimientos"

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void BtnBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCCBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable resultados = BLL.BuscarAlumno(TxtCCBuscar.Text);
            dataGridView1.DataSource = resultados;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este alumno de la base de datos?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    estudiante.CC = TxtCC.Text;
                    BLL.EliminarEstudiante(estudiante.CC);
                    Limpiar();
                    MessageBox.Show("Alumno eliminado con éxito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    BLL.ConsultarEstudiantes();


                }
                else
                {
                    MessageBox.Show("No se eliminará el alumno del registro.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            finally
            {
                TxtCC.Enabled = true;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCC.Text != string.Empty && TxtDireccion.Text != string.Empty && TxtNombreCompleto.Text != string.Empty && TxtTelefono.Text != string.Empty)
                {

                    estudiante.Nombre = TxtNombreCompleto.Text;
                    estudiante.CC = TxtCC.Text;
                    estudiante.FechaNacimiento = PickerNacimiento.Value.Date;
                    estudiante.Direccion = TxtDireccion.Text;
                    estudiante.Telefono = TxtTelefono.Text;

                    string fechaNacimiento = estudiante.FechaNacimiento.ToString("yyyy-MM-dd");


                    BLL.AgregarEstudiante(estudiante.CC, estudiante.Nombre, Convert.ToDateTime(fechaNacimiento), estudiante.Direccion, estudiante.Telefono);

                    MessageBox.Show("Estudiante agregado de manera correcta.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }
                else
                {

                    MessageBox.Show("¡Aún tienes datos que llenar!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar estudiante: " + ex.Message);

            }
            finally
            {
                MostrarDgv();   
            }
        }



        private void BtnModificarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCC.Text != string.Empty && TxtDireccion.Text != string.Empty && TxtNombreCompleto.Text != string.Empty && TxtTelefono.Text != string.Empty)
                {

                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea modificar esta información del alumno?", "Mensaje de confirmación", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        estudiante.Nombre = TxtNombreCompleto.Text;
                        estudiante.CC = TxtCC.Text;
                        estudiante.FechaNacimiento = PickerNacimiento.Value.Date;
                        estudiante.Direccion = TxtDireccion.Text;
                        estudiante.Telefono = TxtTelefono.Text;

                        string fechaNacimiento = estudiante.FechaNacimiento.ToString("yyyy-MM-dd");
                        BLL.ModificarEstudiante(estudiante.Nombre, estudiante.CC, Convert.ToDateTime(fechaNacimiento), estudiante.Direccion, estudiante.Telefono);

                        MessageBox.Show("Estudiante modificado con éxito.", "Mesanje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se modificarán los datos del estudiante", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }

                }
                else
                {

                    MessageBox.Show("Todos los campos deben estar llenos para poder modificar!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            catch (Exception ex)
            {

                    MessageBox.Show("Error al modificar el estudiante: ", ex.Message);
                }
                finally
                {
                    MostrarDgv();
                    TxtCC.Enabled = true;
                }


            }






        #endregion

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_AsignarGrado_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_EstudiantesGrados ventana = new Frm_EstudiantesGrados();
                ventana.ShowDialog();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: ", ex.Message);;
            }
        }
    }
}