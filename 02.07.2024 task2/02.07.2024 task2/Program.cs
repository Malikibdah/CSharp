using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07._2024_task2
{
    internal class Program
    {
        //1.Define an Interface
        //cerat interface class with out write the word class just interface and we can't inhanse an opject from the interface class in main
        public interface ISound  
        {
            void MakeSound();  // creat method .. in interface class we declear the method without the body {} 
        }

        //2.Define an Abstract Class
        // creat abstract class and we can't inhanse an opject from the interface class in main
        public abstract class Animal   
        {
            public string Name { set; get; } // field

            public Animal(string name) //creat constractor with parameter string name
            {
                Name = name;
            }

            public abstract void Eat(); // creat method  .. in abstract class we declear the method without the body {}

            public void Sleep()
            {
                Console.WriteLine($"{Name} is Sleeping ");
            }
        }

        //3.Implement Concrete Classes
        class Dog : Animal, ISound  
        {
            public override void Eat()
            {
                Console.WriteLine($"The animal {Name} eat meat");
            }
            public void MakeSound()
            {
                Console.WriteLine($"The animal {Name} sound is Woof! Woof!");
            }
            public Dog(string name) : base(name)
            {
            }  

        }

        //3.Implement Concrete Classes
        class Cat : Animal, ISound  
        {
            public override void Eat()
            {
                Console.WriteLine($"The animal {Name} eat meat");
            }
            public void MakeSound()
            {
                Console.WriteLine($"The animal {Name} sound is ");
            }
            public Cat(string name) : base(name)
            {
            }  

        }
        static void Main(string[] args)
        {
            //4. Create a Program to Test Your Classes
            Dog dog = new Dog("doge");
            dog.Sleep();
            dog.Eat();
            dog.MakeSound();

            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine();

            Cat cat = new Cat("Cat");
            cat.Sleep();
            cat.Eat();
            cat.MakeSound();

        }
    }
}
