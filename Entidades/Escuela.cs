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

        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     this.AñoDeCreacion = año;
        // }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
    }
}