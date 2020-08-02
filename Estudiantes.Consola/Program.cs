using Estudiantes.AccesoDatos;
using Estudiantes.Educacion;
using Estudiantes.Entidad;
using Estudiantes.Implementacion;
using System;

namespace Estudiantes.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Institucion MiInstitucion = new Institucion();

            MiInstitucion.MatricularEstudiante(new EstudianteAplicado());
            MiInstitucion.CondecorrarEstudiante(new EstudianteAplicado());

            var estudianteAplicado = new EstudianteAplicado();
            estudianteAplicado.Id = 1;
            estudianteAplicado.Nombre = "Jose";
            estudianteAplicado.Apellido = "Perez";
            Console.WriteLine(estudianteAplicado.ConcurrirAClases());

            MiInstitucion.MatricularEstudiante(new EstudianteRelajado());
            MiInstitucion.SuspenderEstudiante();
            var estudianteRelajado = new EstudianteRelajado();
            estudianteRelajado.Id = 1;
            estudianteRelajado.Nombre = "Maria";
            estudianteRelajado.Apellido = "Lopez";
            Console.WriteLine(estudianteRelajado.Conversar());

            MiInstitucion.MatricularEstudiante(new EstudianteDescuidado());
            var estudianteDescuidado = new EstudianteDescuidado();
            estudianteDescuidado.Id = 1;
            estudianteDescuidado.Nombre = "Stiven";
            estudianteDescuidado.Apellido = "Suarez";
            Console.WriteLine(estudianteDescuidado.Investigar());

            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            applicationDbContext.Estudiantes.Add(new Estudiante());
            applicationDbContext.SaveChanges();


            Console.ReadKey();

        }
    }
}
