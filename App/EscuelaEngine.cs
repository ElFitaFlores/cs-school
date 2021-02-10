using CoreEscuela.Entidades;
using System.Collections.Generic;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
            Init();
        }

        public void Init()
        {
            Escuela = new Escuela("Platzi Academy", 1992, TiposEscuela.Secundaria, pais: "Guatemala", ciudad: "Guate");
            Escuela.Cursos = new List<Curso> {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" },
            };
        }
    }
}