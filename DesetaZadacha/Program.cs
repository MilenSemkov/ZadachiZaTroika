using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesetaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many are the car you want to have in your race: ");
            int n = int.Parse(Console.ReadLine());
            List<Car>  list = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Brand: ");
                string brand= Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("PlateNumber: ");
                string number = Console.ReadLine();

                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());


                Console.WriteLine(" ");
                Car cola = new Car(brand,model ,number,year);
                list.Add(cola);
            }
           
            foreach (Car car in list)
            {
                Console.WriteLine(car.ImDriving());
                Console.WriteLine(car.ImIEco());
                Console.WriteLine(car.Print());
                Console.WriteLine("");
            }
            Console.WriteLine("The num of the cars is "+n);
        }
    }
}
