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
using ENTITY;

namespace PRESENTACION
{
    public partial class FrmEstudiantes : Form
    {
        BLL_Estudiantescs BLL = new BLL_Estudiantescs();
        
        public FrmEstudiantes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                E_Estudiantes estudiante = new E_Estudiantes();
                estudiante.Nombre = TxtNombreCompleto.Text;
                estudiante.CC = TxtCC.Text;
                estudiante.FechaNacimiento = PickerNacimiento.Value.Date;
                estudiante.Direccion = TxtDireccion.Text;
                estudiante.Telefono = TxtTelefono.Text;

                string fechaNacimiento = estudiante.FechaNacimiento.ToString("yyyy-MM-dd");


                BLL.AgregarEstudiante(estudiante.Nombre, estudiante.CC, Convert.ToDateTime(fechaNacimiento), estudiante.Direccion, estudiante.Telefono);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar estudiante: " + ex.Message);

            }




        }
    }
}
