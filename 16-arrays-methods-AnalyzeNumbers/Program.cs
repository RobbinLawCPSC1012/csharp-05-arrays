using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_arrays_methods_AnalyzeNumbers
{
    class Program
    {

        static double[] GetItems()
        {
            Console.Write("Enter the number of items: ");
            int size = int.Parse(Console.ReadLine());

            double[] arr = new double[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            return arr;
        }

        static double AverageValue(double[] numArray)
        {
            double sum = 0;
            foreach(double num in numArray)
            {
                sum += num;
            }
            return sum / numArray.Length;
        }

        static void DisplayArrayElements(double[] numArray)
        {
            Console.WriteLine("Number List:");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write($"{numArray[i]} ");
            }
            Console.WriteLine();
        }

        static void ShuffleArrayElements(double[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randIdx = r.Next(arr.Length);
                double tmp = arr[i];
                arr[i] = arr[randIdx];
                arr[randIdx] = tmp;
            }
        }

        static void Main(string[] args)
        {
            double[] numbers = GetItems();
            DisplayArrayElements(numbers);

            ShuffleArrayElements(numbers);
            DisplayArrayElements(numbers);

            double avg = AverageValue(numbers);
            Console.WriteLine("The average value is " + avg);
        }
    }
}
