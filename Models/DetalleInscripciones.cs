namespace Inscripcioness.Models
{
    public class DetalleInscripciones
    {
        public int Id { get; set; }
        public int ModalidadCursado { get; set; }
        public int InscripcionId { get; set; }
        public Inscripcion Inscripcion { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
    }
}
