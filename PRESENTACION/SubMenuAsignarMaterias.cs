using BLL;
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

namespace PRESENTACION
{
    public partial class SubMenuAsignarMaterias : Form
    {


        B_Materias materias = new B_Materias();
        E_Materias valores = new E_Materias();
        B_Grados grados = new B_Grados();
        B_GestionDocentes docentes = new B_GestionDocentes();

        public SubMenuAsignarMaterias()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadComboBoxData1();
            LoadComboBoxData2();
            MostrarDgvMaterias();
            limpiar();
        }


        public void MostrarDgvMaterias()
        {
            dataGridView1.DataSource = materias.MostrarMaterias();
            this.Formato();
            limpiar();
        }


        public void limpiar()
        {
            CboxMateriaID.Text = "";
            CboxDocente.Text = "";
            CboxGrado.Text = "";
            CboxDocente.Enabled = true;

        }

        private void LoadComboBoxData2()
        {
            try
            {

                DataTable datos = grados.MostrarGrados();
                CboxGrado.DataSource = datos;
                CboxGrado.DisplayMember = "NombreGrado";
                CboxGrado.ValueMember = "GradoID";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LoadComboBoxData1()
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

        private void LoadComboBoxData()
        {
            try
            {
                DataTable dataTable = docentes.MostrarDocentes();
                CboxDocente.DataSource = dataTable;
                CboxDocente.DisplayMember = "NombreCompleto"; // La columna que se muestra en el ComboBox
                CboxDocente.ValueMember = "CC"; // El valor que se asocia con cada ítem (puedes cambiar esto según lo que necesites)


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Código de la materia";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].HeaderText = "Nombre de la materia";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Cédula del docente";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].HeaderText = "Nombre del docente";
            dataGridView1.Columns[3].Width = 500;
        }

        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                string DocenteID = Convert.ToString(CboxDocente.SelectedValue);
                valores.DocenteID1 = DocenteID;

                string MateriaID = Convert.ToString(CboxMateriaID.SelectedValue);
                valores.MateriaID1 = MateriaID;

                string GradoID = Convert.ToString(CboxGrado.SelectedValue);
                valores.GradoID1 = Convert.ToInt32(GradoID);

                materias.VincularMateria(valores.MateriaID1, valores.DocenteID1,valores.GradoID1);
                MessageBox.Show("¡Se ha asignado el docente a la materia de manera exitosa!", "Mensaje del sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDgvMaterias();
                limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CboxDocente.Enabled = false;
                string DocenteID = Convert.ToString(CboxDocente.SelectedValue);
                valores.DocenteID1 = DocenteID;

                string MateriaID = Convert.ToString(CboxMateriaID.SelectedValue);
                valores.MateriaID1 = MateriaID;

                string GradoID = Convert.ToString(CboxGrado.SelectedValue);
                valores.GradoID1 = Convert.ToInt32(GradoID);

                materias.CambiarAsignacion(valores.MateriaID1, valores.DocenteID1, valores.GradoID1);
                MessageBox.Show("Se ha cambiado la asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDgvMaterias();
                limpiar();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                limpiar();
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Desea modificar la asignación de este docente?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    BtnEliminar.Visible = true;
                    BtnModificar.Visible = true;
                    if (dataGridView1.RowCount > 0)
                    {
                        CboxDocente.Text = dataGridView1.CurrentRow.Cells["DocenteID"].Value.ToString();
                        CboxMateriaID.Text = dataGridView1.CurrentRow.Cells["MateriaID"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult resultado =  MessageBox.Show("¿Está seguro de que desea eliminar la asignación de esta materia del docente?", "Mensaje del sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    valores.MateriaID1 = CboxMateriaID.Text;
                    materias.EliminarAsignacion(valores.MateriaID1);
                    MessageBox.Show("¡Asignación eliminada con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDgvMaterias();
                    limpiar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
