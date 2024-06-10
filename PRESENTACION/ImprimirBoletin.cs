using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class ImprimirBoletin : Form
    {
        public ImprimirBoletin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Imprimir);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();

        }


        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            int ancho = 800;
            int y = 20;
            int x = 10;
            int lineHeight = 20;
            int especiales = 0;
            int especialesv = 0;
            int centrado = 0;

            e.Graphics.DrawString("INSTITUCION EDUCATIVA JUAN MEJÍA GOMEZ", fontBold, Brushes.Black, new RectangleF(centrado = 235, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("AUTORIZADO POR LA SECRETARIA DE EDUCACION DPTAL SEGÚN", font, Brushes.Black, new RectangleF(centrado = 190, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("RESOLUCION No. 003311 DEL 09 DE DICIEMBRE DE 2010", font, Brushes.Black, new RectangleF(centrado = 220, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("REGISTRO DANE: 120178000093 NIT: 824,001,5947", font, Brushes.Black, new RectangleF(centrado = 235, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("INFORME PERIÓDICO DE EVALUACIONES", fontBold, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight)); // Blank line for spacing

            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            e.Graphics.DrawString("CÓDIGO: 001120", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("NOMBRE: RODRIGUEZ TAPIA CRISTIAM ALEJANDRO", font, Brushes.Black, new RectangleF(especiales = 153, y = 160, ancho, lineHeight));
   
            e.Graphics.DrawLine(Pens.Black, especiales = 9, especialesv = 159, especiales = 9, y + 15 * lineHeight);
            e.Graphics.DrawString("CURSO: 0502", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("PERIODO: 3", font, Brushes.Black, new RectangleF(especiales = 120 , y = 180, ancho, lineHeight));
            e.Graphics.DrawString("PROMEDIO: 86", font, Brushes.Black, new RectangleF(especiales += especiales, y = 180, ancho, lineHeight));
            e.Graphics.DrawString("AÑO: 2022", font, Brushes.Black, new RectangleF(especiales = 380, y = 180, ancho, lineHeight));
            e.Graphics.DrawString("JORNADA: DIURNA", font, Brushes.Black, new RectangleF(especiales = 470, y = 180, ancho, lineHeight));
            e.Graphics.DrawString("PUESTO: 4 de 21", font, Brushes.Black, new RectangleF(especiales = 640, y = 180, ancho, lineHeight));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight)); // Blank line for spacing
            e.Graphics.DrawLine(Pens.Black, x, y = 195, ancho, y = 195);
            e.Graphics.DrawLine(Pens.Black, especiales = 800, especiales = 160, especiales = 800, especialesv = 400);

            // Header for the table
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            e.Graphics.DrawString("ÁREAS Y ASIGNATURAS", fontBold, Brushes.Black, new RectangleF(x, y += lineHeight, 300, lineHeight)); // Incremento de ancho
            e.Graphics.DrawString("IH", fontBold, Brushes.Black, new RectangleF(310, y, 50, lineHeight));
            e.Graphics.DrawString("1°P", fontBold, Brushes.Black, new RectangleF(360, y, 50, lineHeight));
            e.Graphics.DrawString("2°P", fontBold, Brushes.Black, new RectangleF(410, y, 50, lineHeight));
            e.Graphics.DrawString("3°P", fontBold, Brushes.Black, new RectangleF(460, y, 50, lineHeight));
            e.Graphics.DrawString("4°P", fontBold, Brushes.Black, new RectangleF(510, y, 50, lineHeight));
            e.Graphics.DrawString("PR", fontBold, Brushes.Black, new RectangleF(560, y, 50, lineHeight));
            e.Graphics.DrawString("FLS", fontBold, Brushes.Black, new RectangleF(610, y, 50, lineHeight));
            e.Graphics.DrawString("Desempeño", fontBold, Brushes.Black, new RectangleF(660, y, 150, lineHeight));
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight); // Line after header

            // Drawing vertical lines to separate columns
            e.Graphics.DrawLine(Pens.Black, 300, y, 300, y + 12 * lineHeight); // After subject names
            e.Graphics.DrawLine(Pens.Black, 350, y, 350, y + 12 * lineHeight); // After IH
            e.Graphics.DrawLine(Pens.Black, 400, y, 400, y + 12 * lineHeight); // After 1°P
            e.Graphics.DrawLine(Pens.Black, 450, y, 450, y + 12 * lineHeight); // After 2°P
            e.Graphics.DrawLine(Pens.Black, 500, y, 500, y + 12 * lineHeight); // After 3°P
            e.Graphics.DrawLine(Pens.Black, 550, y, 550, y + 12 * lineHeight); // After 4°P
            e.Graphics.DrawLine(Pens.Black, 600, y, 600, y + 12 * lineHeight); // After PR
            e.Graphics.DrawLine(Pens.Black, 650, y, 650, y + 12 * lineHeight); // After FLS
            e.Graphics.DrawLine(Pens.Black, 800, y, 800, y + 12 * lineHeight); // After Desempeño del Periodo

            // Rows of the table
            void DrawRow(string subject, string ih, string p1, string p2, string p3, string p4, string pr, string fls, string performance)
            {
                e.Graphics.DrawString(subject, font, Brushes.Black, new RectangleF(x, y += lineHeight, 300, lineHeight)); // Incremento de ancho
                e.Graphics.DrawString(ih, font, Brushes.Black, new RectangleF(310, y, 50, lineHeight));
                e.Graphics.DrawString(p1, font, Brushes.Black, new RectangleF(360, y, 50, lineHeight));
                e.Graphics.DrawString(p2, font, Brushes.Black, new RectangleF(410, y, 50, lineHeight));
                e.Graphics.DrawString(p3, font, Brushes.Black, new RectangleF(460, y, 50, lineHeight));
                e.Graphics.DrawString(p4, font, Brushes.Black, new RectangleF(510, y, 50, lineHeight));
                e.Graphics.DrawString(pr, font, Brushes.Black, new RectangleF(560, y, 50, lineHeight));
                e.Graphics.DrawString(fls, font, Brushes.Black, new RectangleF(610, y, 50, lineHeight));
                // Alineando desempeño
                e.Graphics.DrawString(performance.PadRight(10), font, Brushes.Black, new RectangleF(660, y, 150, lineHeight));

            }

            // Drawing each row of the table
            DrawRow("CIENCIAS NATURALES", "4", "95", "70", "80", "", "82", "", "ALTO");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("CIENCIAS SOCIALES", "4", "90", "95", "90", "", "92", "", "SUPERIOR");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("EDUCACION ARTISTICA", "2", "90", "90", "90", "", "90", "", "SUPERIOR");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("EDUCACION ETICA", "2", "85", "85", "82", "", "82", "", "ALTO");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("EDUCACION FISICA Y DEPORTE", "2", "80", "85", "85", "", "83", "", "ALTO");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("EDUCACION RELIGIOSA", "2", "85", "80", "", "", "82", "", "ALTO");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("HUMANIDADES CASTELLANO", "5", "90", "88", "88", "", "88", "", "SUPERIOR");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("HUMANIDADES INGLÉS", "2", "90", "85", "85", "", "85", "", "ALTO");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("MATEMÁTICAS", "5", "100", "95", "85", "", "93", "", "SUPERIOR");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("TECNOLOGÍA E INFORMÁTICA", "2", "80", "75", "90", "", "82", "", "SUPERIOR");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            DrawRow("COMPORTAMIENTO ESCOLAR", "", "100", "100", "100", "100", "100", "", "SUPERIOR");
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            // Agregar separación entre filas

        }




    }
}
