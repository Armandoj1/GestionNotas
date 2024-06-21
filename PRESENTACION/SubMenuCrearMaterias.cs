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
using System.Net.NetworkInformation;

namespace PRESENTACION
{
    public partial class SubMenuCrearMaterias : Form
    {
        B_Materias materias = new B_Materias();
        E_Materias valores = new E_Materias();

        public SubMenuCrearMaterias()
        {
            InitializeComponent(); // Asegúrate de llamar a InitializeComponent primero
            MostrarDgvMaterias();
        }

        public void formato()
        {
            dataGridView1.Columns[0].HeaderText = "Código de materia";
            dataGridView1.Columns[0].Width = 530;
            dataGridView1.Columns[1].HeaderText = "Nombre Materia";
            dataGridView1.Columns[1].Width = 972;
        }

        public void MostrarDgvMaterias()
        {
            dataGridView1.DataSource = materias.MostrarMateriasCreacion();
            this.formato();
        }

        public void Limpiar()
        {
            TxtCodigoMateria.Enabled = true;
            TxtCodigoMateria.Text = "";
            TxtNombreMateria.Text = "";
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtCodigoMateria.Text == "" && TxtNombreMateria.Text == "")
                {
                    MessageBox.Show("¡Por favor, rellene todos los campos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    valores.MateriaID1 = TxtCodigoMateria.Text;
                    valores.NombreMateria1 = TxtNombreMateria.Text;

                    materias.AgregarMateria(valores.MateriaID1, valores.NombreMateria1);
                    MessageBox.Show("¡Se ha añadido una nueva materia a la base de datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            finally
            {
                Limpiar();
                MostrarDgvMaterias();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas modificar los datos de esta materia?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if(resultado == DialogResult.Yes)
            {
                    valores.MateriaID1 = TxtCodigoMateria.Text;
                    valores.NombreMateria1 = TxtNombreMateria.Text;

                    materias.ModificarMateria(valores.NombreMateria1, valores.MateriaID1);
                    MessageBox.Show("Se han modificado los datos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    MostrarDgvMaterias();
                }
            else
                {
                    MessageBox.Show("No se modificará la información de la materia", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se ha podido modificar la información de la materia: " + ex.Message, "Mensaje de error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
      
            try
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar la información de esta materia?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    valores.MateriaID1 = TxtCodigoMateria.Text;

                    materias.EliminarMateria(valores.MateriaID1);

                    MessageBox.Show("Se eliminaron los datos de esta materia", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    MostrarDgvMaterias();
                }
                else
                {
                    MessageBox.Show("No se eliminarán los datos de esta materia", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al intentar eliminar los datos: " + ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea manipular la información de esta materia?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (resultado == DialogResult.Yes)
                {
                    TxtCodigoMateria.Enabled = false;
                    if (dataGridView1.RowCount > 0 && e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                        string NombreMateria = row.Cells["NombreMateria"].Value.ToString();
                        string MateriaID = row.Cells["MateriaID"].Value.ToString();

                        TxtNombreMateria.Text = NombreMateria;
                        TxtCodigoMateria.Text = MateriaID;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
    }
}
