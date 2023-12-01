using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevetaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a =int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b=int.Parse(Console.ReadLine());
            List <int>num = new List <int>();
           
            for (int i = a; i <= b; i++)
            {
                num.Add(i);
                
            }
            Console.WriteLine("The sum of the nums between a and b is: "+SumOfNums(a,b));
            Console.WriteLine("The multipied of the nums between a and b is: " + MultiOfNums(a, b));
        }
        static int SumOfNums(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
               
                sum += i;
            }
            return sum;
        }
        static int MultiOfNums(int a, int b)
        {
            int multi = 1;
            for (int i = a; i <= b; i++)
            {

                multi *= i;
            }
            return multi;
        }
    }
}
