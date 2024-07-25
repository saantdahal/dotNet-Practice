using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program

    {
        public class Person
        {
            public string name;
            public int age;

            // Deafault Constructor
            public Person()
            {
                name = "Unkwoun";
                age = 0;
            }
            // Parameterized Constructor
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }




            static void Main(string[] args)

            {
                //Console.WriteLine("Enter your name:");
                //string name = Console.ReadLine();
                
                //Console.WriteLine("Enter your age:");
                //int age = int.Parse(Console.ReadLine());


                Person p1 = new Person();
                Console.WriteLine($"Person 1 Name: {p1.name} Person 1 Age: {p1.age}");


            }
        }
    }
}
