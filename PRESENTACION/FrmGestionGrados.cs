using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BLL;
using ENTITY;
using MessageBox = System.Windows.Forms.MessageBox;


namespace PRESENTACION
{
    public partial class FrmGestionGrados : Form
    {
        B_Grados grados = new B_Grados();
        E_Grados variables = new E_Grados();

        #region "Detalles"



        public void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Co. Grado";
            dataGridView1.Columns[0].Width = 115;
            dataGridView1.Columns[1].HeaderText = "Grado";
            dataGridView1.Columns[1].Width = 111;


        }

        public void Formato2()
        {

            DgvEstudiantesSinGrados.Columns[0].HeaderText = "Cédula";
            DgvEstudiantesSinGrados.Columns[0].Width = 140;
            DgvEstudiantesSinGrados.Columns[1].HeaderText = "Nombre completo";
            DgvEstudiantesSinGrados.Columns[1].Width = 250;
            DgvEstudiantesSinGrados.Columns[2].HeaderText = "F. Nacimiento";
            DgvEstudiantesSinGrados.Columns[2].Width = 150;
            DgvEstudiantesSinGrados.Columns[3].HeaderText = "Dirección";
            DgvEstudiantesSinGrados.Columns[3].Width = 160;
            DgvEstudiantesSinGrados.Columns[4].HeaderText = "Teléfono";
            DgvEstudiantesSinGrados.Columns[4].Width = 123;


        }
        public void Formato3()
        {

            DgvEstudiantesConGrados.Columns[0].HeaderText = "Cédula";
            DgvEstudiantesConGrados.Columns[0].Width = 140;
            DgvEstudiantesConGrados.Columns[1].HeaderText = "Nombre completo";
            DgvEstudiantesConGrados.Columns[1].Width = 250;
            DgvEstudiantesConGrados.Columns[2].HeaderText = "F. Nacimiento";
            DgvEstudiantesConGrados.Columns[2].Width = 150;
            DgvEstudiantesConGrados.Columns[3].HeaderText = "Grado";
            DgvEstudiantesConGrados.Columns[3].Width = 160;
            DgvEstudiantesConGrados.Columns[4].HeaderText = "Teléfono";
            DgvEstudiantesConGrados.Columns[4].Width = 123;


        }
        public void MostrarGrados()
        {

            dataGridView1.DataSource = grados.MostrarGrados();
            this.Formato();
        }
    
        public void MostrarEstudiante()
        {
            DgvEstudiantesSinGrados.DataSource = grados.MostrarEstudiantes();
            this.Formato2();
        }
    
        public void MostrarConGrados()
        {
            DgvEstudiantesConGrados.DataSource = grados.MostrarConGrados();
            this.Formato3();
        }
        public void Limpiar()
        {
            Txt_GradoID.Text = "";
            TxtCCEstudiante.Text = "";
        }


        #endregion

        public FrmGestionGrados()
        {
            InitializeComponent();
            MostrarEstudiante();
            MostrarGrados();
       

        }


        #region "Procedimientos"
        private void BtnAgregarGrados_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_GradoID.Text != string.Empty)
                {
                    grados.VincularGrado(variables.EstudianteID, variables.GradoID);

                    MessageBox.Show("¡Se ha vinculado el estudiante al grado de manenar exitosa!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MostrarEstudiante();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarGrados_Click_1(object sender, EventArgs e)
        {


        }
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DgvEstudiantesSinGrados.Rows.Count > 0)
            {
                string Cedula = DgvEstudiantesSinGrados.CurrentRow.Cells["CC"].Value.ToString();
                TxtCCEstudiante.Text = Cedula;
                variables.EstudianteID = Cedula;
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    string GradoID = dataGridView1.CurrentRow.Cells["GradoID"].Value.ToString();
                    Txt_GradoID.Text = GradoID;
                    variables.GradoID = Convert.ToInt32(GradoID);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                BtnAgregarGrados.Visible = false;
                BtnEliminarGrados.Visible = true;
                DgvEstudiantesConGrados.Visible = true;
                MostrarConGrados();
                BtnCambiar.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);;
            }
            finally
            {
                
            }
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            try
            {

                grados.Modificar(variables.GradoID, variables.EstudianteID);

                MessageBox.Show("¡Se ha reasignado el grados del estudiante de manera exitosa!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {

                DialogResult resultado = MessageBox.Show("¿Deseas volver al menú de vinculación de grados?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    BtnAgregarGrados.Visible = true;
                    BtnEliminarGrados.Visible = false;
                    DgvEstudiantesConGrados.Visible = false;
                    BtnCambiar.Visible = false;
                    MostrarEstudiante();
                }
                else
                {
                    MostrarConGrados();

                }

            
                

            }
        

        }

        private void DgvEstudiantesConGrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvEstudiantesConGrados.Rows.Count > 0)
            {
                string Cedula = DgvEstudiantesConGrados.CurrentRow.Cells["CC"].Value.ToString();
                TxtCCEstudiante.Text = Cedula;
                variables.EstudianteID = Cedula;
            }
        }

        private void BtnEliminarGrados_Click(object sender, EventArgs e)
        {

            try
            {

                variables.EstudianteID = TxtCCEstudiante.Text;
                grados.EliminarEstudianteGrado(variables.EstudianteID);
                MessageBox.Show("¡Se ha desvinculado el estudiante del grado de manera exitosa!", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarConGrados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar desvincular el estudiante del grado: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                DialogResult resultado = MessageBox.Show("¿Deseas volver al menú de vinculación de grados?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    BtnAgregarGrados.Visible = true;
                    BtnEliminarGrados.Visible = false;
                    DgvEstudiantesConGrados.Visible = false;
                    BtnCambiar.Visible = false;
                    MostrarEstudiante();
                }
                else
                {
                    MostrarConGrados();
                }

            }

        }
    }
}
