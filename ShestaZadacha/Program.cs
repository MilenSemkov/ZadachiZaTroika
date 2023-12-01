using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedmaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            int sumNonZeros = 0;
            int countZeros = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Put a num: ");
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] == 0)
                {
                    countZeros++;
                }
                else
                {
                    sumNonZeros += nums[i];
                }
            }
            Console.Write("The sum of non-zeros numbers is: "+sumNonZeros);
            Console.Write("\nThe count of the zeros num is: "+countZeros);
            Console.WriteLine("");

        }
    }
}
