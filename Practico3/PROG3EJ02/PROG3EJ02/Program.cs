using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo(4);
            Cuadrado cuadrado1 = new Cuadrado(12);

            Console.WriteLine(circulo1.CalcularArea());
            Console.WriteLine(cuadrado1.CalcularArea());
            Console.ReadLine();
        }
    }
}
