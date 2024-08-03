using System;

namespace Inheritance
{
    internal class Program
    {
        public class Employee
        {
            protected string firstName="Ram";
            protected string lastName="Sharma";
            protected int employeeID=42;
            protected float salary=1500.2f;


        }

        public class Manager : Employee
        {
            string department= "HOD";

            public void displayMethod(){
                System.Console.WriteLine("======================================");
                System.Console.WriteLine($"|  First Name of the employee: {firstName}   |");
                System.Console.WriteLine($"|  Last Name of the employee: {lastName} |");
                System.Console.WriteLine($"|  Employee ID: {employeeID}                   |");
                System.Console.WriteLine($"|  Salary of the employee: {salary}    |");
                System.Console.WriteLine($"|  Department of the employee: {department}   |");
                System.Console.WriteLine("======================================");
                
            }
        }
        static void Main(String[] args)
        {
          Manager m1 = new Manager();
          m1.displayMethod();
        }
    }
}