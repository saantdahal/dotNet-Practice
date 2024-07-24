using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExample
{
    internal class Program
    {
        // Create a Class 'car'
        class Car
        {
            public String carName;
            public int currSpeed;

            //create a methood 'printState'
            public void printState()
            {
                Console.WriteLine($"{carName} is going {currSpeed} Kmph");
            }

            public void speedUp(int delta)
            {
                currSpeed += delta;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with c# objects");
            Car myCar = new Car();
            myCar.currSpeed = 20;
            myCar.carName = "Tesla";
            for (int i = 0; i < 20; i++)
            {
                myCar.speedUp(10);
                myCar.printState();
            }
        }
    }
}
