using System;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            Printer.DibujarLinea(20);
            Printer.DibujarTitulo("Escuela");
            Console.WriteLine(engine.Escuela);
            Printer.MyBeep();
        }
    }
}
