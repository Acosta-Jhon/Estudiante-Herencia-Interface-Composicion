using Estudiantes.Entidad;
using Estudiantes.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Estudiantes.Implementacion
{
    public class EstudianteDescuidado : IEstudiante, IEquatable<EstudianteRelajado>
    {
        //Unicamente Composicion
        private Estudiante estudiante = new Estudiante();

        [Key]
        public int Id { get => estudiante.Id; set => estudiante.Id = value; }
        public string Nombre { get => estudiante.Nombre; set => estudiante.Nombre = value; }
        public string Apellido { get => estudiante.Apellido; set => estudiante.Apellido = value; }
        public string CorreoInstitucional { get => estudiante.CorreoInstitucional; set => estudiante.CorreoInstitucional = value; }
        public string Celular { get => estudiante.Celular; set => estudiante.Celular = value; }
        public List<string> LibrosAcademicos { get; set; } 
        public List<string> CuadernosAcademicos { get; set; }


        public bool Equals([AllowNull] EstudianteRelajado other)
        {
            return this.Id == other.Id;
        }

        public string ConcurrirAClases()
        {
            return "A veces me quedo dormido y no llego a las primeras horas";
        }

        public string Conversar()
        {
            return "Se dialoga de cualquier tema que se de";
        }

        public string Estudiar()
        {
            return "Para mi es sufiente con que haya prestado atencion";
        }

        public string HacerDeberes()
        {
            return "Le pido a mi bro que me acolie con uno que otro deber";
        }

        public string Investigar()
        {
            return "Si investigo en la red me entretengo en el fb";
        }

        public string Leer()
        {
            return "Para mi leer es aburrido y una perdidad de tiempo"; 
        }

        public string Participar()
        {
            return "";
        }

        public string PonerAtencion()
        {
            return "";
        }
    }
}
