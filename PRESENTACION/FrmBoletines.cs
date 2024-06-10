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

namespace PRESENTACION
{
    public partial class FrmBoletines : Form
    {

        B_Boletines boletines = new B_Boletines();
        public FrmBoletines()
        {
            InitializeComponent();
            MostrarBoletin();
            LoadComboBoxMateria();
            LoadComboBoxGrado();
        }


        public void LoadComboBoxGrado()
        {
            B_Grados grados = new B_Grados();
            CboxGrado.DataSource = grados.MostrarGrados();
            CboxGrado.DisplayMember = "NombreGrado";
            CboxGrado.ValueMember = "GradoID";
        }

        public void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Identificación";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].HeaderText = "Nombre del estudiante";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Grado";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "Materia";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].HeaderText = "Nota";
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].HeaderText = "Periodo";
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].HeaderText = "Observaciones";
            dataGridView1.Columns[6].Width = 860;


        }

        public void LoadComboBoxMateria()
        {
            B_Materias materias = new B_Materias();
            CboxMateria.DataSource = materias.MostrarMateriasCreacion();
            CboxMateria.DisplayMember = "NombreMateria";
            CboxMateria.ValueMember = "MateriaID";
        }

        public void MostrarBoletin()
        {
            dataGridView1.DataSource = boletines.MostrarBoletin();
            Formato();
        }

        private void BtnFiltradoGrados_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int GradoID = Convert.ToInt32(CboxGrado.SelectedValue);
            dataGridView1.DataSource = boletines.MostrarBoletinesGrados(GradoID);
            Formato();

        }

        private void TxtGrado_TextChanged(object sender, EventArgs e)
        {
            string NombreGrado = TxtGrado.Text;
            dataGridView1.DataSource = boletines.MostrarBoletinesGradosManual(NombreGrado);
            Formato();
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            string NombreGrado = TxtCedula.Text;
            dataGridView1.DataSource = boletines.MostrarBoletinesEstudiantes(NombreGrado);
            Formato();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MateriaID = Convert.ToString(CboxMateria.SelectedValue);
            dataGridView1.DataSource = boletines.MostrarBoletinesMateria(MateriaID);
            Formato();
        }

        private void TxtMateria_TextChanged(object sender, EventArgs e)
        {
            string NombreMateria = TxtMateria.Text;
            dataGridView1.DataSource = boletines.MostrarBoletinesMateriaManual(NombreMateria);
            Formato();
        }
    }
    }
