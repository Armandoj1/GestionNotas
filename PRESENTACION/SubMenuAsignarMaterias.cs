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
    public partial class SubMenuAsignarMaterias : Form
    {


        BLL.B_Materias materias = new BLL.B_Materias();
        ENTITY.E_Materias valores = new ENTITY.E_Materias();
        BLL.B_GestionDocentes docentes = new BLL.B_GestionDocentes();

        public SubMenuAsignarMaterias()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadComboBoxData1();
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
            CboxDocente.Enabled = true;

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
            dataGridView1.Columns[3].Width = 300;
        }

        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                string DocenteID = Convert.ToString(CboxDocente.SelectedValue);
                valores.DocenteID1 = DocenteID;

                string MateriaID = Convert.ToString(CboxMateriaID.SelectedValue);
                valores.MateriaID1 = MateriaID;

                materias.VincularMateria(valores.MateriaID1, valores.DocenteID1);
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

                materias.CambiarAsignacion(valores.MateriaID1, valores.DocenteID1);
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
    }
}
