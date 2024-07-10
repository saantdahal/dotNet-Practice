using System;

namespace BasicOperations
{
    class Program
    {
        static void Main(String [] args)
        {
            // Declare varibles of different data types

            int myInt = 50;
            String name = "ram";
            Boolean myBul = true;
            double myDou=50.3;
            char myChar= 'c';

            // Print the variable to console

            System.Console.WriteLine("Integer: "+ myInt);
            System.Console.WriteLine("String: "+name);
            System.Console.WriteLine("Boolean: "+myBul);
            System.Console.WriteLine("Double: "+myDou);
            System.Console.WriteLine("Character: "+myChar);
            System.Console.WriteLine();

            // Perform Basic operations
             int sum = myInt+6;
             double product = myDou *3.5;
             string combinedString = myChar + name;
             bool isfalse = !myBul;

           // Printing the value

           System.Console.WriteLine("Sum: "+ sum);
           System.Console.WriteLine("Product: "+ product);
           System.Console.WriteLine("Combined String: "+combinedString);
           System.Console.WriteLine("Boolean : "+ isfalse);
        }
    }
}
