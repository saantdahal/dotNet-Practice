using System;
namespace BasicOperator

{
    //Write a program that takes two integers as input and performs all the arithmetic operations on them. Display the results
    class Program
    {
        static void Main(String[] args)
        {
            System.Console.WriteLine("Enter first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Add:"+(num1+num2));
            System.Console.WriteLine("Sub:"+ (num1-num2));
            System.Console.WriteLine("Mul:"+ (num1*num2));
            System.Console.WriteLine("Div:"+ (num1/num2));
            System.Console.WriteLine("Mod:"+ (num1%num2));

            
            
        }
    }
}
