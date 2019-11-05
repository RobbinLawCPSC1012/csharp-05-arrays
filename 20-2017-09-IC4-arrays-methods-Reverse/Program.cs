using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_arrays_methods_AnalyzeNumbers
{
    class Program
    {

        static string[] GetWords()
        {
            Console.Write("Enter the number of words as an int: ");
            int size = int.Parse(Console.ReadLine());

            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter next word");
                arr[i] = Console.ReadLine();
            }
            return arr;
        }

        static void DisplayArrayElements(string[] stringArray)
        {
            Console.WriteLine("Number List:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write($"{stringArray[i]} ");
            }
            Console.WriteLine();
        }

        static string[] ReverseArrayElements(string[] arr)
        {
            string[] reverseArray = new string[arr.Length];
            int countDown = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                reverseArray[countDown] = arr[i];
                countDown--;
            }
            return reverseArray;
        }

        static void Main(string[] args)
        {
            string[] wordArray = GetWords();
            DisplayArrayElements(wordArray);
            string[] reverseWordArray = ReverseArrayElements(wordArray);
            DisplayArrayElements(reverseWordArray);
        }
    }
}
