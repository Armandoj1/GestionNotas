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



        
        public FrmMateriasGrados()
        {
            InitializeComponent();
            Mostrar();
            LoadComboBoxData(); 
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
            dataGridView1.Columns[1].Width = 155;
            dataGridView1.Columns[2].HeaderText = "Materias";
            dataGridView1.Columns[2].Width = 455;
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






    }
}
