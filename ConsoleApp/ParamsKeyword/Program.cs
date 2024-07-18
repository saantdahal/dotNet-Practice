using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    internal class Program
    {

        public static void PrintNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args)
        {
            PrintNumbers(1, 2, 3, 4);
            

        }

    }
}
