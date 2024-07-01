using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myopj = new Car("Deutschland", 2024, "AUDI", 75000, "A6Sedan", 15748, "black");

            myopj.Startengine();
            myopj.Stopengine();
            
            Console.WriteLine(myopj.Carinfo());

            BMW bMW =new BMW("Deutschland", 2022, "BMW", 85000, "A10", 14528, "red");
            bMW.Startengine();
            bMW.Stopengine();
            Console.WriteLine(bMW.Carinfo());
            
            


        }
    }
}
