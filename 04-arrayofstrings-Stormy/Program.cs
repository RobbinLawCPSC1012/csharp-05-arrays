using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_arrayofstrings_Stormy
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] myCharArray = {'c', 'd', 'e'};
            int[] myIntArray = {1, 2, 4, 7};
            double[] myDoubleArray = {3.4, 6.8, 88.88};

            string[] stormStrength =
            {
                "No Hurricane. It's just windy yo.",
                "HURRICANE --- Category 1",
                "HURRICANE --- Category 2",
                "HURRICANE --- Category 3",
                "HURRICANE --- Category 4",
                "HURRICANE --- Category 5"
            };

            Console.WriteLine("Enter Wind speed in mph:");
            int speed = int.Parse(Console.ReadLine());
            int stormLevel = 0;

            if (speed >= 74 && speed <= 95)
                stormLevel = 1;
            else if (speed >= 96 && speed <= 110)
                stormLevel = 2;
            else if (speed >= 111 && speed <= 130)
                stormLevel = 3;
            else if (speed >= 131 && speed <= 155)
                stormLevel = 4;
            else if (speed > 155)
                stormLevel = 5;

            string stormString = stormStrength[stormLevel];
            Console.WriteLine($"STORM LEVEL: {stormString}");
        }
    }
}
