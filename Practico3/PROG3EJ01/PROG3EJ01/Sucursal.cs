using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3EJ01
{
    internal class Sucursal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public int poblacion { get; set; } 

        public Sucursal(int id, string nombre, string ciudad, int poblacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.poblacion = poblacion;
        }

        

        public string getNombre() { return this.nombre; }
        public string getCiudad() { return this.ciudad; }
        public int getPoblacion() { return this.poblacion; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setCiudad(string ciudad) { this.ciudad = ciudad; }
        public void setPoblacion(int poblacion) { this.poblacion = poblacion; }

        public void ordenarSucursales(List<Sucursal> listaSucursales)
        {
            listaSucursales.OrderBy(x => x.poblacion).ToList().ForEach(x => Console.WriteLine(x));
        }

        public void mostrarSucursalSegunDpto(List<Sucursal> listaSucursales)
        {
            foreach (Sucursal sucursal in listaSucursales)
            {
                if (sucursal.ciudad == "Melo")
                {
                    Console.WriteLine("\nSucursal Melense, ID: " + sucursal.id);
                }
                else if (sucursal.ciudad == "Maldonado")
                {
                    Console.WriteLine("\nSucursal Fernando A, ID: " + sucursal.id);
                }
                else if (sucursal.ciudad == "Rocha")
                {
                    Console.WriteLine("\nSucursal Rochense, ID: " + sucursal.id);
                }
                else
                {
                    Console.WriteLine("\nSucursal Uruguaya");
                }
            }
        }

    }
}
