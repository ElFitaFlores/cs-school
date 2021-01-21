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
            Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela);
        }
    }
}
