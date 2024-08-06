using System;

namespace Inheritance
{
    internal class Program
    {
        class Santosh{
            public int a, b,c;
            public void ReadData(int a, int b){
                this.a = a;
                this.b =b;
            }
        public void display()
        {
            System.Console.WriteLine("value of a is :"+ a);
            System.Console.WriteLine("value of b is :"+ b);
        }
        }

      static void Main(String[] args)
      {
        System.Console.WriteLine("");

        // Abstract Class k padhne hai
      }
    }
}