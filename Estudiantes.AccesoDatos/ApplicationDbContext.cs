using Estudiantes.Entidad;
using Microsoft.EntityFrameworkCore;
using System;

namespace Estudiantes.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
