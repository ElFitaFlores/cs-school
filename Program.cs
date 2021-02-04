using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 1992, TiposEscuela.Secundaria, pais: "Guatemala", ciudad: "Guate");
            escuela.TipoEscuela = TiposEscuela.Primaria;

            escuela.Cursos = new List<Curso> {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" },
            };
            escuela.Cursos.Add(new Curso { Nombre = "401" });
            var otraColeccion = new List<Curso> {
                new Curso() { Nombre = "501" },
                new Curso() { Nombre = "601" },
                new Curso() { Nombre = "701" },
            };
            escuela.Cursos.AddRange(otraColeccion);
            otraColeccion.Clear();
            escuela.Cursos.Remove();
            Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela);
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
