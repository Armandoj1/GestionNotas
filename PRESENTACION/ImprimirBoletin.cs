using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BLL;
using ENTITY;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace PRESENTACION
{
    public partial class ImprimirBoletin : Form
    {
        private B_Boletines boletin;
        private List<E_Boletines> notas;
        private int currentPageIndex;
        B_Estudiantescs Estudiante = new B_Estudiantescs();

        public ImprimirBoletin()
        {
            InitializeComponent();
            boletin = new B_Boletines();
            LblEsEstudiante.Text = E_Usuarios.Rol2;
            currentPageIndex = 0;
            CargarCorreo();
            ValidarEstudiante();
        }

        public void ValidarEstudiante()
        {
            if (LblEsEstudiante.Text == "Estudiante")
            {
                TxtCC.Enabled = false;
                TxtCC.Text = E_Usuarios.Usuario2;
            }
        }

        public void CargarCorreo()
        {
            // Obtener el valor de la columna "Correo" de la fila actualmente seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;

            if (filaSeleccionada != null)
            {
                // Obtener el valor de la columna "Correo" (posición 13 en base cero)
                string correo = filaSeleccionada.Cells[13].Value.ToString();

                // Asignar el valor de correo al txtCorreo.Text
                txtCorreo.Text = correo;
            }
        }

        public void Formato()
        {
            dataGridView1.Columns[0].HeaderText = "Identificación";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].HeaderText = "Grado";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "GradoID";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].HeaderText = "Materia";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].HeaderText = "Nota 1°P ";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderText = "Nota 2°P ";
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].HeaderText = "Nota 3°P ";
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].HeaderText = "Nota 4°P ";
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[11].Width = 352;
            dataGridView1.Columns[13].Visible = false;
        }

        public void Mostrar()
        {
            //dataGridView1.DataSource = boletin.MostrarBoletin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notas = boletin.ObtenerNotasPorEstudiante(TxtCC.Text);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Imprimir);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
            System.Drawing.Font fontBold = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            int ancho = 800;
            int y = 20;
            int x = 10;
            int lineHeight = 20;

            e.Graphics.DrawString("INSTITUCION EDUCATIVA JUAN MEJÍA GOMEZ", fontBold, Brushes.Black, new RectangleF(235, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("AUTORIZADO POR LA SECRETARIA DE EDUCACION DPTAL SEGÚN", font, Brushes.Black, new RectangleF(190, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("RESOLUCION No. 003311 DEL 09 DE DICIEMBRE DE 2010", font, Brushes.Black, new RectangleF(220, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("REGISTRO DANE: 120178000093 NIT: 824,001,5947", font, Brushes.Black, new RectangleF(235, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("INFORME PERIÓDICO DE EVALUACIONES", fontBold, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight)); // Blank line for spacing

            // Cuadro de identificación y nombre
            int idBoxStartY = y + lineHeight;
            e.Graphics.DrawLine(Pens.Black, x, idBoxStartY, ancho, idBoxStartY); // Línea horizontal superior del cuadro
            e.Graphics.DrawString($"Identificación: {notas[0].EstudianteCC}", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString($"NOMBRE: {notas[1].NombreEstudiante}", font, Brushes.Black, new RectangleF(230, y, ancho, lineHeight));
            e.Graphics.DrawString($"CURSO: {notas[1].NombreGrado}", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight));
            e.Graphics.DrawString("PERIODO: 3", font, Brushes.Black, new RectangleF(120, y, ancho, lineHeight));
            e.Graphics.DrawString($"PROMEDIO: {notas[1].Promedio.ToString("0.0")}", font, Brushes.Black, new RectangleF(240, y, ancho, lineHeight));
            e.Graphics.DrawString("AÑO: 2024", font, Brushes.Black, new RectangleF(380, y, ancho, lineHeight));
            e.Graphics.DrawString("JORNADA: DIURNA", font, Brushes.Black, new RectangleF(470, y, ancho, lineHeight));
            e.Graphics.DrawString($"PUESTO: {notas[1].Puesto}", font, Brushes.Black, new RectangleF(640, y, ancho, lineHeight));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(x, y += lineHeight, ancho, lineHeight)); // Blank line for spacing

            int idBoxEndY = y; // Fin del cuadro de identificación y nombre
            e.Graphics.DrawLine(Pens.Black, x, idBoxEndY, ancho, idBoxEndY); // Línea horizontal inferior del cuadro

            e.Graphics.DrawLine(Pens.Black, x, idBoxStartY, x, idBoxEndY); // Línea vertical izquierda del cuadro
            e.Graphics.DrawLine(Pens.Black, ancho, idBoxStartY, ancho, idBoxEndY); // Línea vertical derecha del cuadro

            // Línea horizontal entre la sección de identificación y la tabla de calificaciones
            e.Graphics.DrawLine(Pens.Black, x, y += lineHeight, ancho, y);

            // Header for the table
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);
            e.Graphics.DrawString("ÁREAS Y ASIGNATURAS", fontBold, Brushes.Black, new RectangleF(x, y += lineHeight, 250, lineHeight));
            e.Graphics.DrawString("1°P", fontBold, Brushes.Black, new RectangleF(260, y, 50, lineHeight));
            e.Graphics.DrawString("2°P", fontBold, Brushes.Black, new RectangleF(310, y, 50, lineHeight));
            e.Graphics.DrawString("3°P", fontBold, Brushes.Black, new RectangleF(360, y, 50, lineHeight));
            e.Graphics.DrawString("4°P", fontBold, Brushes.Black, new RectangleF(410, y, 50, lineHeight));
            e.Graphics.DrawString("PR", fontBold, Brushes.Black, new RectangleF(460, y, 50, lineHeight));
            e.Graphics.DrawString("Desempeño", fontBold, Brushes.Black, new RectangleF(510, y, 100, lineHeight));
            e.Graphics.DrawString("Observación", fontBold, Brushes.Black, new RectangleF(610, y, 180, lineHeight));
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, ancho, y + lineHeight);

            // Store the starting Y position of the table
            int tableStartY = y;

            // Drawing each row of the table
            foreach (var nota in notas)
            {
                DrawRow(e, font, x, ref y, lineHeight, nota.Materia, nota.Nota1.ToString("00.0"), nota.Nota2.ToString("00.0"), nota.Nota3.ToString("00.0"), nota.Nota4.ToString("00.0"), nota.Promedio.ToString("00.0"), nota.Desempeno, nota.Observacion);
            }

            // Adjust the height of the vertical lines to match the table height
            int tableEndY = y + lineHeight;
            e.Graphics.DrawLine(Pens.Black, x, tableStartY, x, tableEndY); // Línea vertical izquierda del cuadro de asignaturas
            e.Graphics.DrawLine(Pens.Black, 250, tableStartY, 250, tableEndY); // After subject names
            e.Graphics.DrawLine(Pens.Black, 300, tableStartY, 300, tableEndY); // After 1°P
            e.Graphics.DrawLine(Pens.Black, 350, tableStartY, 350, tableEndY); // After 2°P
            e.Graphics.DrawLine(Pens.Black, 400, tableStartY, 400, tableEndY); // After 3°P
            e.Graphics.DrawLine(Pens.Black, 450, tableStartY, 450, tableEndY); // After 4°P
            e.Graphics.DrawLine(Pens.Black, 500, tableStartY, 500, tableEndY); // After PR
            e.Graphics.DrawLine(Pens.Black, 610, tableStartY, 610, tableEndY); // After Desempeño del Periodo
            e.Graphics.DrawLine(Pens.Black, 800, tableStartY, 800, tableEndY); // After Observación
        }

        private void DrawRow(PrintPageEventArgs e, System.Drawing.Font font, int x, ref int y, int lineHeight, string subject, string p1, string p2, string p3, string p4, string pr, string performance, string observation)
        {
            e.Graphics.DrawString(subject, font, Brushes.Black, new RectangleF(x, y += lineHeight, 250, lineHeight));
            e.Graphics.DrawString(p1, font, Brushes.Black, new RectangleF(260, y, 50, lineHeight));
            e.Graphics.DrawString(p2, font, Brushes.Black, new RectangleF(310, y, 50, lineHeight));
            e.Graphics.DrawString(p3, font, Brushes.Black, new RectangleF(360, y, 50, lineHeight));
            e.Graphics.DrawString(p4, font, Brushes.Black, new RectangleF(410, y, 50, lineHeight));
            e.Graphics.DrawString(pr, font, Brushes.Black, new RectangleF(460, y, 50, lineHeight));
            e.Graphics.DrawString(performance, font, Brushes.Black, new RectangleF(510, y, 100, lineHeight));
            e.Graphics.DrawString(observation, font, Brushes.Black, new RectangleF(610, y, 180, lineHeight));
            e.Graphics.DrawLine(Pens.Black, x, y + lineHeight, 800, y + lineHeight); // Line after row
        }

        private void TxtCC_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = boletin.MostrarParaImprimir(TxtCC.Text);
            Formato();
        }

        private void ImprimirBoletin_Load(object sender, EventArgs e)
        {
            CargarCorreo();
        }

        // Botón para generar PDF y enviarlo por correo
        private void button2_Click(object sender, EventArgs e)
        {
            notas = boletin.ObtenerNotasPorEstudiante(TxtCC.Text);
            string pdfPath = CrearPDF();
            if (pdfPath != null)
            {
                EnviarCorreoConPDF(pdfPath);
            }
        }

        private string CrearPDF()
        {
            string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Boletin.pdf");
            Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
                doc.Open();

                // Definir las fuentes
                iTextSharp.text.Font font = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontBold = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD);

                // Añadir textos principales
                AddParagraph(doc, "INSTITUCION EDUCATIVA JUAN MEJÍA GOMEZ", fontBold, Element.ALIGN_CENTER);
                AddParagraph(doc, "AUTORIZADO POR LA SECRETARIA DE EDUCACION DPTAL SEGÚN", font, Element.ALIGN_CENTER);
                AddParagraph(doc, "RESOLUCION No. 003311 DEL 09 DE DICIEMBRE DE 2010", font, Element.ALIGN_CENTER);
                AddParagraph(doc, "REGISTRO DANE: 120178000093 NIT: 824,001,5947", font, Element.ALIGN_CENTER);
                AddParagraph(doc, "INFORME PERIÓDICO DE EVALUACIONES", fontBold, Element.ALIGN_LEFT);
                AddParagraph(doc, " ", font, Element.ALIGN_LEFT); // Blank line for spacing

                // Cuadro de identificación y nombre
                PdfPTable idTable = new PdfPTable(4);
                idTable.WidthPercentage = 100;
                idTable.SetWidths(new float[] { 1, 2, 1, 1 });

                // Fila 1
                AddCellToTableWithBorders(idTable, $"Identificación: {notas[0].EstudianteCC}", font);
                AddCellToTableWithBorders(idTable, $"NOMBRE: {notas[1].NombreEstudiante}", font, 3);

                // Fila 2
                AddCellToTableWithBorders(idTable, $"CURSO: {notas[1].NombreGrado}", font);
                AddCellToTableWithBorders(idTable, "PERIODO: 3", font);
                AddCellToTableWithBorders(idTable, $"PROMEDIO: {notas[1].Promedio.ToString("0.0")}", font);
                AddCellToTableWithBorders(idTable, "AÑO: 2024", font);

                // Fila 3
                AddCellToTableWithBorders(idTable, "JORNADA: DIURNA", font);
                AddCellToTableWithBorders(idTable, $"PUESTO: {notas[1].Puesto}", font, 3);

                // Añadir el cuadro al documento
                doc.Add(idTable);

                AddParagraph(doc, " ", font, Element.ALIGN_LEFT); // Blank line for spacing

                // Header de la tabla de calificaciones
                PdfPTable table = new PdfPTable(8);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3, 1, 1, 1, 1, 1, 2, 3 });

                AddCellToTableWithBorders(table, "ÁREAS Y ASIGNATURAS", fontBold);
                AddCellToTableWithBorders(table, "1°P", fontBold);
                AddCellToTableWithBorders(table, "2°P", fontBold);
                AddCellToTableWithBorders(table, "3°P", fontBold);
                AddCellToTableWithBorders(table, "4°P", fontBold);
                AddCellToTableWithBorders(table, "PR", fontBold);
                AddCellToTableWithBorders(table, "Desempeño", fontBold);
                AddCellToTableWithBorders(table, "Observación", fontBold);

                // Añadir filas a la tabla
                foreach (var nota in notas)
                {
                    AddCellToTableWithBorders(table, nota.Materia, font);
                    AddCellToTableWithBorders(table, nota.Nota1.ToString("00.0"), font);
                    AddCellToTableWithBorders(table, nota.Nota2.ToString("00.0"), font);
                    AddCellToTableWithBorders(table, nota.Nota3.ToString("00.0"), font);
                    AddCellToTableWithBorders(table, nota.Nota4.ToString("00.0"), font);
                    AddCellToTableWithBorders(table, nota.Promedio.ToString("00.0"), font);
                    AddCellToTableWithBorders(table, nota.Desempeno, font);
                    AddCellToTableWithBorders(table, nota.Observacion, font);
                }

                doc.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el PDF: " + ex.Message);
                return null;
            }
            finally
            {
                doc.Close();
            }

            return pdfPath;
        }

        private void AddParagraph(Document doc, string text, iTextSharp.text.Font font, int alignment)
        {
            Paragraph paragraph = new Paragraph(text, font)
            {
                Alignment = alignment
            };
            doc.Add(paragraph);
        }

        private void AddCellToTableWithBorders(PdfPTable table, string text, iTextSharp.text.Font font, int colspan = 1)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font))
            {
                Border = iTextSharp.text.Rectangle.BOX,
                Padding = 5,
                Colspan = colspan
            };
            table.AddCell(cell);
        }

        private void EnviarCorreoConPDF(string pdfPath)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("gestionnotas1@gmail.com");
                mail.To.Add(txtCorreo.Text);
                mail.Subject = "Boletín de calificaciones";
                mail.Body = "Adjunto encontrará su boletín de calificaciones.";

                Attachment attachment = new Attachment(pdfPath);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("gestionnotas1@gmail.com", "o q n s u w f d r s k q v k d d");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Correo enviado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}