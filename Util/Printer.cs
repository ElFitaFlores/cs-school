using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void DibujarTitulo(string titulo)
        {
            var size = titulo.Length + 4;
            DibujarLinea(size);
            WriteLine($"| {titulo} |");
            DibujarLinea(size);
        }

        public static void MyBeep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                Beep(hz, tiempo);
            }
        }
    }
}