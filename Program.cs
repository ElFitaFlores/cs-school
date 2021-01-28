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

            escuela.Cursos = new Curso[] {
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301" },
            };
            Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela);
            // Console.WriteLine(curso1.UniqueId);
            // Console.WriteLine(curso2.UniqueId);
            //ImprimirCursos(arregloCursos);
            escuela.ImprimirCursos();
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"El nombre del curso es {arregloCursos[contador].Nombre}");
                contador += 1;
            }
        }
    }
}
