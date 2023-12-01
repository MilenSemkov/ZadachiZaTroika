using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> simpNum = new List<int>();
            List<int> evenNum = new List<int>();
            int num;
            do
            {
                //proverka za prosti chisla
                Console.Write("Put a num: ");
                num = int.Parse(Console.ReadLine());
                if (IsPrime(num) == true)
                {
                    Console.WriteLine("The num is simple!");
                    simpNum.Add(num);
                }
                else
                {
                    Console.WriteLine("The num isn't simple!");
                }

                //Proverka za Even nums
                if (IsEven(num) == true)
                {
                    Console.WriteLine("The num is even!");
                    evenNum.Add(num);
                }
                else
                {
                    Console.WriteLine("The num is odd!");
                }


            } while (num != 0);
            //premahvam nulevite stoinosti 
            evenNum.Remove(0);
            simpNum.Remove(0);
            //otpezatvane na listovete
            Console.Write("The list with simple numbers: " + string.Join(", ", simpNum));
            Console.Write("\nThe list with even numbers: " + string.Join(", ", evenNum));
            Console.ReadKey();
        }
        static bool IsPrime(int n)
        {
            for (int i = 2; i*i<=n; i++)
            {
                
                if (n % i == 0)
                {
                    return false;
                    
                }

            }
            return true;
        }
        static bool IsEven(int n)
        {
            
            if (n % 2 == 0)
            {
                return true;

            }
            
            return false;
        }
    }
}
