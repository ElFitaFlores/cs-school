using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela)
        {
            this.Escuela = escuela;

        }
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
            Init();
        }

        public void Init()
        {
            Escuela = new Escuela("Platzi Academy", 1992, TiposEscuela.Secundaria, pais: "Guatemala", ciudad: "Guate");
            CargasCursos();
            CargasAsignaturas();
            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos = GenerarAlumnos();
            }
            CargasEvaluaciones();
        }

        private void CargasEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargasAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Física"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private IEnumerable<Alumno> GenerarAlumnos(int cantidad = 10)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargasCursos()
        {
            Escuela.Cursos = new List<Curso> {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" },
            };

            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnos(cantidadRandom);
            }
        }
    }
}