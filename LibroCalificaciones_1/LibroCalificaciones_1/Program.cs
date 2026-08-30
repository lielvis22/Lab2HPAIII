using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroCalificaciones_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LibroCalificacion MyLibro = new LibroCalificacion();
            MyLibro.MostrarMensaje();
        }
    }
}
