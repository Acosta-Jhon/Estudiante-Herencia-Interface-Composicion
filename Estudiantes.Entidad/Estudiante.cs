using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estudiantes.Entidad
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Celular { get; set; }
        public List<string> LibrosAcademicos { get; set; }
        public List<string> CuadernosAcademicos { get; set; }
    }
}