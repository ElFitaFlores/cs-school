using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            Console.WriteLine(engine.Escuela);
        }
    }
}
