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
    public partial class SubMenuRegistrarMaterias : Form
    {


        BLL.B_Materias materias = new BLL.B_Materias();
        ENTITY.E_Materias valores = new ENTITY.E_Materias();
        BLL.B_GestionDocentes docentes = new BLL.B_GestionDocentes();

        public SubMenuRegistrarMaterias()
        {
            InitializeComponent();
            LoadComboBoxData();
            MostrarDgvMaterias();
            CboxDocente.Text = "";
        }


        public void MostrarDgvMaterias()
        {
            dataGridView1.DataSource = materias.MostrarMaterias();
            this.Formato();
        }


        public void limpiar()
        {
            TxtCodigoMateria.Text = "";
            TxtNombreMateria.Text = "";
            CboxDocente.Text = "";

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
            dataGridView1.Columns[0].HeaderText = "MateriaID";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Nombre de la materia";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Cédula del docente";
            dataGridView1.Columns[2].Width = 220;
        }
    
        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {

            try
            {
                valores.MateriaID1 = TxtCodigoMateria.Text;
                valores.NombreMateria1 = TxtNombreMateria.Text;
                valores.DocenteID1 = CboxDocente.SelectedValue.ToString();


                materias.AgregarMateria(valores.MateriaID1, valores.NombreMateria1, valores.DocenteID1);

                MessageBox.Show("¡Se ha asignado la materia al docente de manera exitosa!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDgvMaterias();
                limpiar();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar la materia: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
