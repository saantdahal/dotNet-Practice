using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single dimension array
            // Decleration 
            int[] numb = new int[5];
            numb[0] = 10;
            numb[1] = 20;
            numb[2] = 30;
            numb[3] = 40;
            numb[4] = 50;

            //Accesing Element
            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine($"Element at index {i}= {numb[i]}");
            }

            //Multi-Dimension Array
            int[,] matrix = new int[2, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            // Accessing elements
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string value = $"Element at index [{i},{j}]: [matrix[{i},{j}]]";
                    Console.WriteLine(value);
                }
            }




        }
    }
}
