using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public class B_Boletines
    {

        D_Boletines Boletines = new D_Boletines();
        public DataTable MostrarBoletin()
        {
            return Boletines.MostrarBoletines();
        }




        public List<E_Boletines> ObtenerNotasPorEstudiante(string estudianteCC)
        {
            DataTable dt = Boletines.MostrarBoletinesCedula(estudianteCC);
            return ConvertirDataTableALista(dt);
        }

        public List<E_Boletines> ObtenerTodosLosBoletines()
        {
            DataTable dt = Boletines.MostrarBoletines();
            return ConvertirDataTableALista(dt);
        }

        private List<E_Boletines> ConvertirDataTableALista(DataTable dt)
        {
            List<E_Boletines> notas = new List<E_Boletines>();
            foreach (DataRow row in dt.Rows)
            {
                E_Boletines nota = new E_Boletines
                {
                    EstudianteCC = row["EstudianteCC"].ToString(),
                    NombreEstudiante = row["NombreEstudiante"].ToString(),
                    NombreGrado = row["NombreGrado"].ToString(),
                    Materia = row["Materia"].ToString(),
                    Nota1 = row["Nota1"] != DBNull.Value ? Convert.ToDecimal(row["Nota1"]) : 0,
                    Nota2 = row["Nota2"] != DBNull.Value ? Convert.ToDecimal(row["Nota2"]) : 0,
                    Nota3 = row["Nota3"] != DBNull.Value ? Convert.ToDecimal(row["Nota3"]) : 0,
                    Nota4 = row["Nota4"] != DBNull.Value ? Convert.ToDecimal(row["Nota4"]) : 0,
                    Promedio = row["Promedio"] != DBNull.Value ? Convert.ToDecimal(row["Promedio"]) : 0,
                    Desempeno = row["Desempeno"].ToString(),
                    Observacion = row["Observacion"].ToString(),
                    Puesto = row["Puesto"] != DBNull.Value ? Convert.ToInt32(row["Puesto"]) : 0
                };
                notas.Add(nota);
            }
            return notas;
        }
        public DataTable MostrarBoletinesGrados(int GradoID)
        {
            return Boletines.MostrarBoletinesGrados(GradoID);
        }


        public DataTable MostrarBoletinesGradosManual(string GradoID)
        {
            return Boletines.MostrarBoletinesGradosManual(GradoID);
        }


        public DataTable MostrarBoletinesEstudiantes(string EstudianteID)
        {
            return Boletines.MostrarBoletinesCedula(EstudianteID);
        }

        public DataTable MostrarBoletinesMateria(string MateriaID)
        {
            return Boletines.MostrarBoletinesMateria(MateriaID);
        }

        public DataTable MostrarBoletinesMateriaManual(string NombreMateria)
        {
            return Boletines.MostrarBoletinesMateriaManual(NombreMateria);
        }

        public DataTable MostrarParaImprimir(string CC)
        {
            return Boletines.MostrarParaImprimir(CC);
        }


    }
}
