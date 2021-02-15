using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public Evaluaciones() => Guid.NewGuid().ToString();
    }
}