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
    public partial class FrmCrearGrados : Form
    {

        B_Grados grados = new B_Grados();
        E_Grados datos = new E_Grados();
        

        public void Limpiar()
        {
            Txt_NombreGrado.Text = "";
        }

        public FrmCrearGrados()
        {
            InitializeComponent();
            MostrarGrado();
        }


        public void formato()
        {
            dataGridView2.Columns[0].HeaderText = "Código del grado";
            dataGridView2.Columns[0].Width = 445;
            dataGridView2.Columns[1].HeaderText = "Grado";
            dataGridView2.Columns[1].Width = 630;
        }

        public void MostrarGrado()
        {
            dataGridView2.DataSource = grados.MostrarGrados();
            this.formato();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.NombreGrado = Txt_NombreGrado.Text;
                grados.AgregarGrado(datos.NombreGrado);
                MessageBox.Show("¡Grado creado con éxito!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el grado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MostrarGrado();
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtGradoID.Text == "")
                {
                    MessageBox.Show("¡Debes seleccionar un grado primero para modificarlo!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    datos.NombreGrado = Txt_NombreGrado.Text;
                    datos.GradoID = Convert.ToInt32(TxtGradoID.Text);

                    grados.CambiarNombreGrado(datos.NombreGrado, datos.GradoID);
                    MostrarGrado();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el grado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resultaddo = MessageBox.Show("¿Desea modificar el nombre del grado?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultaddo == DialogResult.Yes)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    Txt_NombreGrado.Text = dataGridView2.CurrentRow.Cells["NombreGrado"].Value.ToString();
                    TxtGradoID.Text = dataGridView2.CurrentRow.Cells["GradoID"].Value.ToString();
                }
            }

           
        }

       
    }
}
