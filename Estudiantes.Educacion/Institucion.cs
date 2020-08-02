using Estudiantes.Interface;
using System.Linq.Expressions;

namespace Estudiantes.Educacion
{
    public class Institucion
    {
        public IEstudiante Estudiante { get; set; }

        public string MatricularEstudiante(IEstudiante estudiante) 
        {
            Estudiante = estudiante;
            return "Estudiante matriculado";
        }
        public string CondecorrarEstudiante(IEstudiante estudiante)
        {
            Estudiante = estudiante;
            return "Estudiante condecorrado por su buen nivel academico";
        }

        public string AprobarMaterias()
        {
            return Estudiante.ConcurrirAClases() + "aprobado"
                + Estudiante.Estudiar() + "aprobado"
                + Estudiante.HacerDeberes() + "aprobado"
                + Estudiante.Participar() + "Aprobado";
        }

        public string SuspenderEstudiante()
        {
            return "Estudiante supendido";
        }
    }
}
