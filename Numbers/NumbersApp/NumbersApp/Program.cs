using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listaNumbers = new List<double>();
            listaNumbers.AddRange(new double[] { 25.3, 4.5, 68.4, 67.7, 8.4, 15.6, 10.1 });
            Console.WriteLine("Summan av alla siffror: " + listaNumbers.Sum());
            Console.WriteLine("Medelvärdet: " + listaNumbers.Average().ToString("0.00"));
            Console.WriteLine("Högsta värdet: " + listaNumbers.Max());
            Console.WriteLine("Minsta värdet: " + listaNumbers.Min());
            Console.WriteLine("Minsta värdet fanns på index: " + listaNumbers.IndexOf(listaNumbers.Min()));
            listaNumbers.Sort();
            foreach (double d in listaNumbers)
            {
                Console.WriteLine("Värde: " + d);
            }
        }
    }
}
