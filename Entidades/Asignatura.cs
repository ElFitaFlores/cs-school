using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public Asignatura() => Guid.NewGuid().ToString();
    }
}