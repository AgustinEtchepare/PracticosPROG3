using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3EJ02
{
    internal class Cuadrado : Figura, Dibujable
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return lado * lado;
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujado");
        }
    }
}
