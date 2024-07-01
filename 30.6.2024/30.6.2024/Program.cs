using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._6._2024
{
    internal class Program
    {
        //1 solution
        //static void Sumandavarege()
        //{
        //    int m;
        //    double thesum = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        m = int.Parse(Console.ReadLine());
        //        thesum += m;
        //    }

        //    Console.WriteLine($"the sum of your number is : {thesum} and the avarege is {thesum / 10}");
        //}


        //2 solution
        //static void Thecubeofnumber()
        //{
        //    int num;
        //    double thecube = 0;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        num = int.Parse(Console.ReadLine());
        //        thecube = num * num * num;
        //        Console.WriteLine($"Number is : {num} and cube of the {num} is : {thecube}");
        //    }

        //}


        //3 solution
        //public static int Thegreateryear(int[] years)
        //{

        //    foreach (int year in years)
        //    {
        //        if (year > 1950)
        //        {
        //            Console.WriteLine(year);
        //        }
        //    }
        //    return 0;
        //}

        //4 solution
        //static int Thedayofage()
        //{
        //    int theage;
        //    int thenumberofday;
        //    theage = int.Parse(Console.ReadLine());
        //    thenumberofday = theage * 365;
        //    return thenumberofday;
        //}

        //5 solution
        //public class Person
        //{
        //    public int Age;
        //    public string Gender;
        //    public string Name;
        //    public string Email;
        //    public int Id;
        //    public string Phone;

        //    public  Person (int age, string gender, string name, string email, int id, string phone)
        //    {
        //        Age = age;
        //        Gender = gender;
        //        Name = name;
        //        Email = email;
        //        Id = id;
        //        Phone = phone;


        //        if (age >= 18 && age <= 60)
        //        {
        //            Age = age;
        //        }
        //        else
        //        {
        //            Console.WriteLine("inter valid age between 18 - 60");
        //        }

        //        if (phone[0] == '0' && phone[1] == '7')
        //        {
        //            if (phone[2] == '7' || phone[2] == '8' || phone[2] == '9')
        //            {
        //                Phone = phone;
        //            }
        //            else
        //            {
        //                Console.WriteLine("this number is not valid1");
        //            }
        //        }
        //        else {
        //            Console.WriteLine("this number is not valid2");

        //        }



        //    }
        //    public void Myinfo()

        //    {
        //        Console.WriteLine($"Name: {Name}");
        //        Console.WriteLine($"Age: {Age}");
        //        Console.WriteLine($"Gender: {Gender}");
        //        Console.WriteLine($"Email: {Email}");
        //        Console.WriteLine($"ID: {Id}");
        //        Console.WriteLine($"Phone: {Phone}");
        //    }





        //}
        static void Main(string[] args)
        {
            //1 solution
            //Console.WriteLine("Inter your 10 number : ");
            //Sumandavarege();

            //2 solution
            //Thecubeofnumber();

            //3 solution
            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //Thegreateryear(years);

            //4
            //Console.WriteLine("Inter Your age in year : ");
            //Console.WriteLine($"Your age in days is : {Thedayofage()}");

            //5 solution

            //Person theinfo = new Person(30, "male", "Malik", "malikibdah88@gmail.com", 112233, "0786217123");
            //theinfo.Myinfo();
        }
    }
}
