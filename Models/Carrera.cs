﻿namespace Inscripcioness.Models
{
    public class Carrera
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
