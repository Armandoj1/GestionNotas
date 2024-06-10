using BLL;
using ENTITY;
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
    public partial class FrmMateriasGrados : Form
    {
        B_Materias materias = new B_Materias();
        E_Materias valores = new E_Materias();
        B_Grados grados = new B_Grados();   

        public FrmMateriasGrados()
        {
            InitializeComponent();
            Mostrar();
            LoadComboBoxData();
            LoadComboBoxData1();
        }


        public void Limpiar()
        {
            CboxMateriaID.Text = "";
            CboxGradoID.Text = "";
        }
        public void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Código grado";
            dataGridView1.Columns[0].Width = 155;
            dataGridView1.Columns[1].HeaderText = "Nombre del grado";
            dataGridView1.Columns[1].Width = 185;
            dataGridView1.Columns[2].HeaderText = "Materias";
            dataGridView1.Columns[2].Width = 779;
        }

        public void Mostrar()
        {
            dataGridView1.DataSource = materias.MostrarMateriasGrados();
            this.Formato();
            Limpiar();
        }

        private void LoadComboBoxData()
        {
            try
            {
                DataTable dataTable = materias.MostrarMateriasCreacion();
                CboxMateriaID.DataSource = dataTable;
                CboxMateriaID.DisplayMember = "NombreMateria"; // La columna que se muestra en el ComboBox
                CboxMateriaID.ValueMember = "MateriaID"; // El valor que se asocia con cada ítem (puedes cambiar esto según lo que necesites)
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }


        private void LoadComboBoxData1()
        {
            try
            {
                DataTable datos = grados.MostrarGrados();
                CboxGradoID.DataSource = datos;
                CboxGradoID.DisplayMember = "NombreGrado"; // La columna que se muestra en el ComboBox
                CboxGradoID.ValueMember = "GradoID"; // El valor que se asocia con cada ítem (puedes cambiar esto según lo que necesites)

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {
            try
            {

                valores.MateriaID1 = CboxMateriaID.SelectedValue.ToString();
                valores.GradoID1 = Convert.ToInt32(CboxGradoID.SelectedValue.ToString());

                materias.VincularMateriaGrado(valores.MateriaID1, valores.GradoID1);
                MessageBox.Show("¡Materia agregada al grado de manera correcta!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar vincular la materia al grado: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la asignación de esta materia al grado?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    valores.MateriaID1 = CboxMateriaID.SelectedValue.ToString();
                    valores.GradoID1 = Convert.ToInt32(CboxGradoID.SelectedValue.ToString());


                    materias.EliminarVinculacion(valores.MateriaID1, valores.GradoID1);
                    MessageBox.Show("¡Materia eliminada del grado con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



    }
}
