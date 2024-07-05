using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> colNum = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// Algoritmo de selección
            //for (int i = 0; i < colNum.Count - 1; i++)
            //{
            //    int minIndex = i;
            //    for (int j = i + 1; j < colNum.Count; j++)
            //    {
            //        if (colNum[j] > colNum[minIndex])
            //        {
            //            minIndex = j;
            //        }
            //    }
            //    // Intercambiar los valores
            //    int temp = colNum[i];
            //    colNum[i] = colNum[minIndex];
            //    colNum[minIndex] = temp;
            //}

            //// Imprimir la lista ordenada
            //foreach (int num in colNum)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.ReadLine();

            var suma = colNum.Sum();

            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
