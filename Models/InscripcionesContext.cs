using Microsoft.EntityFrameworkCore;
using Inscripcioness.Models;

namespace Inscripcioness.Models
{
    public class InscripcionesContext : DbContext
    {

        public InscripcionesContext(DbContextOptions<InscripcionesContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;
            //               Database=InscripcionesContext;
            //               User Id = sa; Password = 123;
            //               MultipleActiveResultSets = True;
            //               Encrypt=false");

            string cadenaConexion = "Server=5.57.213.17;Database=smartsof_fabibobadilla;user=smartsof_bobadilla;password=bodadillafabi123";
            optionsBuilder.UseMySql(cadenaConexion,
                ServerVersion.AutoDetect(cadenaConexion));
        }

        public virtual DbSet<Alumno> alumnos { get; set; }
        public virtual DbSet<Carrera> carreras { get; set; }
        public virtual DbSet<Inscripcion> Inscripciones { get; set; }
        public virtual DbSet<AnioCarrera> aniosCarreras { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<DetalleInscripciones> DetalleInscripciones { get; set; }
    }
}
