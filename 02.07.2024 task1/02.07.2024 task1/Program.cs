using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07._2024_task1
{
    internal class Program


    {
        static void Main(string[] args)
        {
            BMW bMW = new BMW(); // opject for BMW class
            bMW.Display();
            Car car = new Car(); // opject for Car class   
            car.Display();
            Car car1 = new BMW();// opject for BMW class with inherit from the base class Car
            car1.Display();
        }
    }
}
