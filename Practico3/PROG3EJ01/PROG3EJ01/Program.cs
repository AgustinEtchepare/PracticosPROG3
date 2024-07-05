using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG3EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sucursal> listaSucursales = new List<Sucursal>();

            Sucursal sucursal1 = new Sucursal(0, "MDO", "Maldonado", 43000);
            Sucursal sucursal2 = new Sucursal(1, "MVDEO", "Montevideo", 99000);
            Sucursal sucursal3 = new Sucursal(3, "MDO2", "Maldonado", 13000);
            Sucursal sucursal4 = new Sucursal(4, "ROCH", "Rocha", 20000);
            Sucursal sucursal5 = new Sucursal(5, "MELO", "Melo", 33333);

            listaSucursales.Add(sucursal1);
            listaSucursales.Add(sucursal2);
            listaSucursales.Add(sucursal3);
            listaSucursales.Add(sucursal4);
            listaSucursales.Add(sucursal5);

            listaSucursales.OrderByDescending(x => x.poblacion).ToList().ForEach(x => Console.WriteLine(x.nombre));

            Console.ReadLine();
        }

    }
}
