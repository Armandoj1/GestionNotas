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
    public partial class Frm_EstudiantesGrados : Form
    {

        E_VincularGrado vincular = new E_VincularGrado();
        B_VincularGrado grados = new B_VincularGrado();

        public Frm_EstudiantesGrados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        #region "Detalles" 
        public void limpiar()
        {
            TxtCC.Text = string.Empty;
            TxtGradoID.Text = string.Empty;
        }

        #endregion



        #region "Procedimientos"
        private void button2_Click(object sender, EventArgs e)
        {
            try
                {
                    if (TxtCC.Text != string.Empty && TxtGradoID.Text != string.Empty)
                    {

                        vincular.CC1 = TxtCC.Text;
                        vincular.GradoID = TxtGradoID.Text;

                    grados.AgregarGrado(vincular.CC1, vincular.GradoID);

                        MessageBox.Show("¡Los datos han sido añadidos con éxito!");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("¡Aún te faltan campos por llenar!", "Mensaje del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al vincular el estudiante: ", ex.Message);

                }
                finally
                {
                    this.Close();
                }
            
        }


        #endregion
    }
}
