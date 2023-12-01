using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsmaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;
            int countOfNegNum = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                count++;
                if (num < 0)
                {
                    countOfNegNum++;
                }
            } while (num!=0);
            Console.Write("The count of all num (without the zero) is: "+(count-1));
            Console.Write("\nThe count of negative num is: "+countOfNegNum);
        }
    }
}
