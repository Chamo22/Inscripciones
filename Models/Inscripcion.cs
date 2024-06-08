namespace Inscripcioness.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int AlumnoID { get; set; }
        public Alumno? Alumno { get; set; }
        public int CarreraId { get; set; }
<<<<<<< HEAD
        public Carrera? Carrera { get; set; }
=======
        public Carrera? Carrera { get; }
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d

    }
}
