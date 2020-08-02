using Estudiantes.Entidad;
using Estudiantes.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Estudiantes.Implementacion
{
    public class EstudianteRelajado : Estudiante, IEstudiante, IEquatable<EstudianteAplicado>
    {
        //Se utilizo Herencia y Composicion

        public bool Equals([AllowNull] EstudianteAplicado other)
        {
            return this.Id == other.Id;
        }

        public string ConcurrirAClases()
        {
            return "Llego un 1 minuto antes de iniciar clases";
        }

        public string Conversar()
        {
            return "Normal se conversa de todo";
        }

        public string Estudiar()
        {
            return "Me pego una repasadita";
        }

        public string HacerDeberes()
        {
            return "Hago mis deberes y ojala esten bien hechos";
        }

        public string Investigar()
        {
            return "Investigo cuando mismo no entiendo";
        }

        public string Leer()
        {
            return "Solo leo si es por una nota";
        }

        public string Participar()
        {
            return "Participo solo li el inge me lo pide";
        }

        public string PonerAtencion()
        {
            return "Atiendo si el tema es interesate caso contrario me da sueno";
        }
    }
}
