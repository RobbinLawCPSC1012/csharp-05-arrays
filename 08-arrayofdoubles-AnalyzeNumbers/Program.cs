using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_arrayofdoubles_AnalyzeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tNumber Analyzer\n");
            Console.Write("Enter number of items: ");
            int size = int.Parse(Console.ReadLine());

            double[] arr = new double[size];
            double sum = 0;

            // Get Each number for the array from the user.
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a number: ");
                arr[i] = double.Parse(Console.ReadLine());
                sum += arr[i];
            }

            double avg = sum / size;
            Console.WriteLine($"Num Elements: {size} Average: {avg}");

            double min = arr[0];
            double max = arr[0];

            double bigCount = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > avg)
                    bigCount++;
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"Number of Elements larger than average: {bigCount}");
            Console.WriteLine($"MaxElt: {max} minElt: {min}");
        }
    }
}
