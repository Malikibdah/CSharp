using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07._2024_task1
{
    internal class Car
    {
        // field
        public string Make;
        public int Year;
        public string Type;
        public int Price;
        public string Model;
        public int PalletNo;
        public string Color;

        public void DisplayInfo( string make,int year) //DisplayInfo function take two parameter string make and int year
        {

        }
        public void DisplayInfo( string make) //DisplayInfo function take one parameter string make 
        {
            
        }
        public virtual void  Display() //virtual to stop the overriding from the base function
        {
            Console.WriteLine("Welcome Car");
        }


    }
    class BMW : Car  //BMW inherit from Car class
    {
        public override void Display()  //override to stop the overriding
        {
            Console.WriteLine("Welcome BMW");
        }
    }
}
