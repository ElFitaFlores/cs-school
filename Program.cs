using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 1992, TiposEscuela.Secundaria, pais: "Guatemala", ciudad: "Guate");
            escuela.TipoEscuela = TiposEscuela.Primaria;

            var curso1 = new Curso()
            {
                Nombre = "101",
            };

            var curso2 = new Curso()
            {
                Nombre = "102",
            };
            Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela);
            Console.WriteLine(curso1.UniqueId);
            Console.WriteLine(curso2.UniqueId);
        }
    }
}
