using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FrmGestionDocentes : Form
    {   

        BLL.B_GestionDocentes docentes = new BLL.B_GestionDocentes();
        ENTITY.E_Docentes valores = new ENTITY.E_Docentes();

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
            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].HeaderText = "Cédula";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Fecha de nacimiento";
            dataGridView1.Columns[2].Width = 190;
            dataGridView1.Columns[3].HeaderText = "Teléfono";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Especialidad";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "Dirección";
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].HeaderText = "Materia";
            dataGridView1.Columns[7].HeaderText = "MateriaID";
        }

        public void Limpiar()
        {
            TxtCC.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEspecialidad.Clear();
            PickerNacimiento.Value = DateTime.Now;
        }
    
    

       

        private void FrmGestionDocentes_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                valores.CC1 = TxtCC.Text;
                valores.Nombre1 = TxtNombre.Text;
                valores.Direccion1 = TxtDireccion.Text;
                valores.Telefono1 = TxtTelefono.Text;
                valores.Especialidad1 = TxtEspecialidad.Text;
                valores.FechaNacimiento1 = PickerNacimiento.Value.Date;

                string fechaNacimiento = valores.FechaNacimiento1.ToString("yyyy-MM-dd");

                docentes.AgregarDocente(valores.Nombre1, valores.CC1, Convert.ToDateTime(fechaNacimiento), valores.Direccion1, valores.Especialidad1, valores.Telefono1);


                MessageBox.Show("¡Docente agregado de manera exitosa!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDgvDocentes();
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar el docente: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
    }
}

