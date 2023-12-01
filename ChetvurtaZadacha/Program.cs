using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetvurtaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num; List<double> list = new List<double>();
            do
            {
                Console.Write("Put a number: ");
                num = double.Parse(Console.ReadLine());
                list.Add(num);
            }
            while (num != 0);


            list.Sort();
            list.Remove(0);
            Console.WriteLine(string.Join("<", list));

        }
    }
}
