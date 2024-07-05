using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3EJ02
{
    internal class Circulo : Figura, Girable
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }


        public double CalcularArea()
        {
            return 3.14 * radio * radio;
        }

        public void Girar()
        {
            Console.WriteLine("Girando");
        }
    }
}
