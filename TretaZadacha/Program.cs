using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Put a number: ");
            int chislo=int.Parse(Console.ReadLine());

            int es;
            List<int> list = new List<int>();
            while(chislo>0)
            {
                es = chislo % 10;
                list.Add(es);
                chislo=chislo/ 10;
            }
            list.Reverse();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
