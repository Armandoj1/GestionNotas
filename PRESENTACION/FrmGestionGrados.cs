using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;


namespace PRESENTACION
{
    public partial class FrmGestionGrados : Form
    {
        B_Grados grados = new B_Grados();
        E_Grados variables = new E_Grados();

        #region "Detalles"



        public void Formato()
        {

            dataGridView1.Columns[0].HeaderText = "Cédula";
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].HeaderText = "Nombre completo";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Telefono";
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].HeaderText = "Grado";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "ID del grado";
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].HeaderText = "Fecha de asignación";
            dataGridView1.Columns[5].Width = 226;


        }
        public void MostrarGrados()
        {

            dataGridView1.DataSource = grados.MostrarGrados();
            this.Formato();
        }

        public void Limpiar()
        {
            Txt_GradoID.Text = string.Empty;
            Txt_NombreGrado.Text = string.Empty;
        }


        #endregion

        public FrmGestionGrados()
        {
            InitializeComponent();
            MostrarGrados();
        }


        #region "Procedimientos"
        private void BtnAgregarGrados_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_GradoID.Text != string.Empty && Txt_NombreGrado.Text != string.Empty)
                {

                    variables.GradoID = Txt_GradoID.Text;
                    variables.NombreGrado = Txt_NombreGrado.Text;

                    grados.AgregarGrado(variables.GradoID, variables.NombreGrado);

                    MessageBox.Show("¡Los datos han sido añadidos con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("¡Aún te faltan campos por llenar!", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar el estudiante: ", ex.Message);

            }
            finally
            {
                MostrarGrados();
            }
        }


        #endregion

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGestionGrados_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
