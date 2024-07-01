using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024
{
    internal class Car
    {
          // field
          private  string CarMake;
          private  int year;
          private  string type;
          private  int price;
          private  string model;
          private  int palletNo;
          private  string color;

        // properties
        public string Make { set { CarMake = value; } get { return CarMake; } }
        public int Year { set { year = value; } get { return year; } }
        public string Type { set { type = value; } get { return type; } }
        public int Price { set { price = value; } get { return price; } }
        public string Model { set { model = value; } get { return model; } }
        public int PalletNo { set { palletNo = value; } get { return palletNo; } }
        public string Color { set { color = value; } get { return color; } }


        public Car(string carMake, int year, string type, int price, string model, int palletNo, string color)
        {
            this.CarMake = carMake;
            this.Year = year;
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.PalletNo = palletNo;
            this.Color = color;
        }

        public void Startengine()
        {
            Console.WriteLine($" The car {Type} start engine");
        }
        public void Stopengine()
        {
            Console.WriteLine($" The car {Type} stop engine");
        }

        public string Carinfo()
        {
           string h= $"Car Made in: {CarMake}, Year is: {Year}, Type is: {Type}, Price is: {Price}, Model is: {Model}, PalletNo is: {PalletNo}, Color is: {Color}.";
            return h;
        }


    }
    class BMW : Car
    {
        public BMW(string Make, int Year, string Type, int Price, string Model, int PalletNo, string Color)
        : base(Make, Year, Type, Price, Model, PalletNo, Color)
        {
            
        }

    }
}

