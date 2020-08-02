using Estudiantes.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estudiantes.Implementacion
{
    public class EstudianteAplicado : IEstudiante
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Celular { get; set; }
        public List<string> LibrosAcademicos { get; set; } = new List<string> { "English","Progrmacion","BD", "Interfaces" };
        public List<string> CuadernosAcademicos { get; set; } = new List<string> { "Matematicas", "Progamacion", "Administracion", "BD" };


        public string ConcurrirAClases()
        {
            return $"Yo soy {Nombre} y llego puntual a clases";
        }

        public string Conversar()
        {
            return $"{Nombre} {Apellido} dialoga con sus colegas";
        }

        public string Estudiar()
        {
            return $"{Nombre} revisa los apuntos de su {CuadernosAcademicos[0]}";
        }

        public string HacerDeberes()
        {
            return $"Reviso mis {LibrosAcademicos[2]} y {CuadernosAcademicos[1]} para realizar mis deberes";
        }

        public string Investigar()
        {
            return $"Con mi { CorreoInstitucional} accedo a internet investigo";
        }

        public string Leer()
        {
            return $"Con mi {CorreoInstitucional} accedo a {LibrosAcademicos[2]} online";
        }

        public string Participar()
        {
            return "Me gusta compartir mi punto de vista de algun tema a tratar";
        }

        public string PonerAtencion()
        {
            return "Me concentro totalmente en clases";
        }
    }
}
