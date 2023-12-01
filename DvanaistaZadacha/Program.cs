using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvanaistaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Put a word: ");
            string duma=Console.ReadLine();
            List<char> list = duma.ToList();
            list.Reverse();
            
            Console.WriteLine("The reverse word is "+string.Join("",list).ToLower());
        }
    }
}
