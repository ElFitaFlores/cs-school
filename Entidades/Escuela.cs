using System;
namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     this.AñoDeCreacion = año;
        // }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public Escuela(string nombre, int año, TiposEscuela tipos, string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre {Nombre}, Tipo {TipoEscuela} \n Pais {Pais} Ciudad {Ciudad}";
        }

        public Curso[] Cursos { get; set; }

        public void ImprimirCursos()
        {
            int contador = 0;
            while (contador < this.Cursos.Length)
            {
                Console.WriteLine($"El nombre del curso es {this.Cursos[contador].Nombre}");
                contador += 1;
            }
        }
    }
}