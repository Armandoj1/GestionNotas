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

namespace PRESENTACION
{


 
    
    public partial class ProgramaPrincipal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Form currentForm = null; // Variable para almacenar el formulario actual

        public ProgramaPrincipal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas cerrar sesión?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                if (currentForm.GetType() == childForm.GetType())
                {
                    // Si el formulario que se intenta abrir ya está abierto, no hacer nada
                    return;
                }
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(childForm);
            PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEstudiantes());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGestionGrados());
        }
    
    
    }
}
