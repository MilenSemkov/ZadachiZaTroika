using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtoraZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r=");
            double r = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double S = 2 * pi * r * (r + h);
            double V = pi * r * r * h;

            Console.WriteLine($"S={S:f2} cm2\nV={V:f2} cm");
        }
    }
}
