using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurvaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c=");
                double c = double.Parse(Console.ReadLine());

                if (a + b < c || a + c < b || b + c < a)
                {
                    Console.WriteLine("This triangle does not exist!");
                    return;
                }
                double perimeter = a + b + c;
                double p = perimeter / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"P={perimeter:f2} cm\nS={S:f2} cm2");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
