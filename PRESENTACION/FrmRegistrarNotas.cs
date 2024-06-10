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
        }

        public void LoadComboBoxMaterias()
        {

            DataTable datos = usuario.ValidarUsuarioDocente(E_Usuarios.Usuario2);
            CboxMateria.DataSource = datos;
            CboxMateria.DisplayMember = "NombreMateria";
            CboxMateria.ValueMember = "MateriaID";

        }

        public void LoadComboBoxGrados()
        {
            DataTable datos = usuario.ValidarUsuarioDocente(E_Usuarios.Usuario2);
            CboxGrado.DataSource = datos;
            CboxGrado.DisplayMember = "NombreGrado";
            CboxGrado.ValueMember = "GradoID";


        }

        public void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Identificación";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[4].Width = 933;

        }
        public void Mostrar()
        {
            int GradoID = Convert.ToInt32(CboxGrado.SelectedValue.ToString());
            dataGridView1.DataSource = notas.MostrarNotas(GradoID);
            this.Formato();
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
                        string periodo = row.Cells["Periodo"].Value?.ToString();
                        string observacion = row.Cells["Observacion"].Value?.ToString();
                        string materiaID = CboxMateria.SelectedValue.ToString();

                        notas.RegistrarNotas(cc, materiaID, Convert.ToInt32(periodo), Convert.ToDecimal(nota), observacion);

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

        private void FrmRegistrarNotas_Load(object sender, EventArgs e)
        {

        }

        private void CboxGrado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Mostrar();
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
                        string Periodo = row.Cells["Periodo"].Value?.ToString();
                        string Observacion = row.Cells["Observacion"].Value?.ToString();
                        string MateriaID = CboxMateria.SelectedValue.ToString();

                        notas.ModificarNota(EstudianteCC, MateriaID, Convert.ToInt32(Periodo), Convert.ToDecimal(nota), Observacion);

                        MessageBox.Show("¡Nota modificada con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
