using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesetaZadacha
{
    internal class Car
    {
        private string brand;
        private string model;
        private string carNumber;
        private int year;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string CarNumber
        {
            get { return carNumber; }
            set { carNumber = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Car(string brand,string model,string carNumber,int year)
        {
            Brand = brand;
            Model = model;
            CarNumber= carNumber;
            Year = year;
        }
        public string ImDriving()
        {
            return $"{brand} {model}: Brym-brum-brum!";
        }
        public string ImIEco()
        {
            if(year<=2000)
            {
                return "Im NOT ECO!";
            }
            return "Im ECO!";
        }
        public string Print()
        {
            return $"Brand: {brand}\nModel: {model}\nPlateNumber: {carNumber}\nYear: {year}";
        }

    }
}
