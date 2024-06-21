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
using System.Windows.Media.Media3D;

namespace PRESENTACION
{
    public partial class FrmRegistrarNotas : Form
    { 
        
        B_GestionNotas notas = new B_GestionNotas();
        B_Usuario usuario = new B_Usuario();

        public FrmRegistrarNotas()
        {
            InitializeComponent();
            LoadComboBoxMaterias();
            LoadComboBoxGrados();
            LoadComboBoxPeriodo();

        }

        public void LoadComboBoxMaterias()
        {
            DataTable datos = usuario.ValidarUsuarioDocente(E_Usuarios.Usuario2);
            CboxMateria.DataSource = datos;
            CboxMateria.DisplayMember = "NombreMateria";
            CboxMateria.ValueMember = "MateriaID";
            CboxMateria.SelectedIndex = -1; // Deselect any selected item initially
        }

        public void LoadComboBoxGrados()
        {
            DataTable datos = usuario.ValidarUsuarioDocente(E_Usuarios.Usuario2);
            CboxGrado.DataSource = datos;
            CboxGrado.DisplayMember = "NombreGrado";
            CboxGrado.ValueMember = "GradoID";
            CboxGrado.SelectedIndex = -1; // Deselect any selected item initially
        }

        public void LoadComboBoxPeriodo()
        {
            DataTable datos = notas.MostrarPeriodo();
            CboxPeriodo.DataSource = datos;
            CboxPeriodo.DisplayMember = "Nombre";
            CboxPeriodo.ValueMember = "PeriodoID";
            CboxPeriodo.SelectedIndex = -1; // Deselect any selected item initially
        }

        public void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Identificación";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[5].HeaderText = "Observacion";
            dataGridView1.Columns[5].Width = 802;
                
        }

        public void Mostrar()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSubirNotas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // Ignorar la fila de nueva entrada
                    {
                        string cc = row.Cells["EstudianteCC"].Value?.ToString();
                        string nombreCompleto = row.Cells["NombreCompleto"].Value?.ToString();
                        string nota = row.Cells["Nota"].Value?.ToString();
                        int PeriodoID = Convert.ToInt32(CboxPeriodo.SelectedValue);
                        string observacion = row.Cells["Observacion"].Value?.ToString();
                        string materiaID = CboxMateria.SelectedValue.ToString();

                        notas.RegistrarNotas(cc, materiaID, PeriodoID, Convert.ToDecimal(nota), observacion);

                        MessageBox.Show("¡Nota registrada con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Iterar sobre cada fila del DataGridView
            
        }


        private void CboxGrado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            try
            {
                Mostrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);;
            }
          
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // Ignorar la fila de nueva entrada
                    {
                        string EstudianteCC = row.Cells["EstudianteCC"].Value?.ToString();
                        string nota = row.Cells["Nota"].Value?.ToString();
                        int PeriodoID = Convert.ToInt32(CboxPeriodo.SelectedValue);
                        string Observacion = row.Cells["Observacion"].Value?.ToString();
                        string MateriaID = CboxMateria.SelectedValue.ToString();

                        notas.ModificarNota(EstudianteCC, MateriaID, PeriodoID, Convert.ToDecimal(nota), Observacion);

                        MessageBox.Show("¡Nota modificada con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            try
            {
                if (CboxMateria.SelectedValue != null && CboxGrado.SelectedValue != null && CboxPeriodo.SelectedValue != null)
                {
                    string MateriaID = CboxMateria.SelectedValue.ToString();
                    int GradoID = Convert.ToInt32(CboxGrado.SelectedValue);
                    int PeriodoID = Convert.ToInt32(CboxPeriodo.SelectedValue);

                    dataGridView1.DataSource = notas.FiltrarRegistroNotas(MateriaID, GradoID, PeriodoID);
                    this.Formato();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione todos los valores en los ComboBoxes.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
