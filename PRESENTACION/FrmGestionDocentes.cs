using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace PRESENTACION
{
    public partial class FrmGestionDocentes : Form
    {   

        B_GestionDocentes docentes = new B_GestionDocentes();
        E_Docentes valores = new E_Docentes();

        public FrmGestionDocentes()
        {
            InitializeComponent();
            MostrarDgvDocentes();
        }

        public void MostrarDgvDocentes()
        {

            dataGridView1.DataSource = docentes.MostrarDocentes();
            this.formato();
        }

        public void formato()
        {
            dataGridView1.Columns[0].HeaderText = "Nombre completo";
            dataGridView1.Columns[0].Width = 290;
            dataGridView1.Columns[1].HeaderText = "Cédula";
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].HeaderText = "Fecha de nacimiento";
            dataGridView1.Columns[2].Width = 190;
            dataGridView1.Columns[3].HeaderText = "Dirección";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Especialidad";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "Telefono";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].HeaderText = "Materia";
            dataGridView1.Columns[6].Width = 140;

        }

        public void Limpiar()
        {
            TxtCC.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEspecialidad.Clear();
            PickerNacimiento.Value = DateTime.Now;
            TxtCC.Enabled = true;
        }
    
    
        
       

        private void FrmGestionDocentes_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCC.Text != "" && TxtNombre.Text != "" && PickerNacimiento.Text != "" && TxtDireccion.Text != ""
                    && TxtEspecialidad.Text != "" && TxtTelefono.Text != "")
                {
                    valores.CC1 = TxtCC.Text;
                    valores.Nombre1 = TxtNombre.Text;
                    valores.Direccion1 = TxtDireccion.Text;
                    valores.Telefono1 = TxtTelefono.Text;
                    valores.Especialidad1 = TxtEspecialidad.Text;
                    //Obtención del datos de la fecha de nacimiento
                    DateTime fechaNacimiento = PickerNacimiento.Value.Date;

                    //Conversión de la fecha de nacimiento a un formato aceptado por la base de datos
                    valores.FechaNacimiento1 = Convert.ToDateTime(fechaNacimiento.ToString("yyyy-MM-dd"));

                    docentes.AgregarDocente(valores.Nombre1, valores.CC1, valores.FechaNacimiento1, valores.Direccion1, valores.Especialidad1, valores.Telefono1);


                    MessageBox.Show("¡Docente agregado de manera exitosa!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDgvDocentes();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("¡Aún faltan datos por llenar!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar el docente: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de qué desea modificar la información del docente?", "Mensaje del sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resultado)
                {
                    valores.Nombre1 = TxtNombre.Text;
                    valores.FechaNacimiento1 = PickerNacimiento.Value.Date;
                    valores.Telefono1 = TxtTelefono.Text;
                    valores.Especialidad1 = TxtEspecialidad.Text;
                    valores.Direccion1 = TxtDireccion.Text;
                    string fechaNacimiento = valores.FechaNacimiento1.ToString("yyyy-MM-dd");
                    valores.CC1 = TxtCC.Text;

                    docentes.ModificarDocente(valores.CC1, valores.Nombre1, Convert.ToDateTime(fechaNacimiento), valores.Direccion1, valores.Especialidad1, valores.Telefono1);

                    MessageBox.Show("¡Datos del docente modificados con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    MostrarDgvDocentes();
                }
                else
                {
                    MessageBox.Show("¡Entendido, no se modificará la información del docente!", "Mensaje del sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar modificar los datos del docente: " + ex.Message);

            }
            finally
            {
               
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show("¿Desea manipular la información del docente?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                TxtCC.Enabled = false;

                if (dataGridView1.RowCount > 0 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    string nombre = row.Cells["NombreCompleto"].Value.ToString();
                    string cc = row.Cells["CC"].Value.ToString();
                    string fechaNacimiento = row.Cells["FechaNacimiento"].Value.ToString();
                    string direccion = row.Cells["Direccion"].Value.ToString();
                    string telefono = row.Cells["Telefono"].Value.ToString();
                    string Especialidad = row.Cells["Especialidad"].Value.ToString();

                    TxtNombre.Text = nombre;
                    TxtCC.Text = cc;
                    PickerNacimiento.Value = DateTime.Parse(fechaNacimiento);
                    TxtDireccion.Text = direccion;
                    TxtTelefono.Text = telefono;
                    TxtEspecialidad.Text = Especialidad;

                }

            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                DataTable resultado = docentes.MostrarDocentesCedula(TxtBuscarCC.Text);
                dataGridView1.DataSource = resultado;
        }

        private void TxtBuscarEspecialidad_TextChanged(object sender, EventArgs e)
        {
            DataTable resultado = docentes.MostrarDocentesEspecialidad(TxtBuscarEspecialidad.Text);
            dataGridView1.DataSource = resultado;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBuscarCC.Text != "")
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar la información de este docente?", "Mensaje del sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        docentes.EliminarDocente(TxtCC.Text);
                        MessageBox.Show("¡Datos del docente eliminado!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡Entendido, no se eliminará la información del docente!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha proporcionado la cédula de ningún docente", "Mensaje del sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar eliminar los datos del docente: " + ex.Message);;
            }
            finally
            {
                Limpiar();
                MostrarDgvDocentes();
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

