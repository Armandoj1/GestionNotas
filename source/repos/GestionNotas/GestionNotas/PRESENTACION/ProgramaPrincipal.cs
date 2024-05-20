using System;
using System.Collections.Generic;
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
        public ProgramaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnGestionEstudiante_Click(object sender, EventArgs e)
        {
            FrmEstudiantes estudiantes = new FrmEstudiantes();
            estudiantes.TopLevel = false; // Esto evita que el formulario secundario se muestre como una ventana independiente.
            PanelPrincipal.Controls.Add(estudiantes); // Agrega el formulario secundario al panel.
            estudiantes.Dock = DockStyle.Fill; // Hace que el formulario secundario se ajuste al tamaño del panel.
            estudiantes.Show();

        }
    }
}
