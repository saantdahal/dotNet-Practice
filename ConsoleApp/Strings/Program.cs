using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string String1 = "Hello";
            string String2 = "World";
            string Result = String1 + " " + String2;
            Console.WriteLine(Result);

            // Length of concatanated string

            Console.WriteLine(Result.Length);

            //Accesing Character

            Console.WriteLine(Result[5]);
            Console.WriteLine();

            // String Methods (Substring)
            string SubString = Result.Substring(9);
            Console.WriteLine(SubString);

            //Replace
            string ReplacedString = Result.Replace("World", "C#");
            Console.WriteLine(ReplacedString);
            Console.WriteLine();

            //Split the concatenated string by space and print each word on a new line

            string[] words = Result.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
                Console.WriteLine();
            }

            //To Upper and to lower

            Console.WriteLine(Result.ToUpper());
            Console.WriteLine(Result.ToLower());

            // Character Array
        }
    }
}
