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

        public void MostrarGrados()
        {

            dataGridView1.DataSource = grados.MostrarGrados();
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
    }
}
