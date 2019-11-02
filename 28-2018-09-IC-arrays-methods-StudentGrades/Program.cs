using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_2018_09_IC_arrays_methods_StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxStudents = 5;
            int[] grades = new int[maxStudents];

            int numStudents = EnterGrades(grades, maxStudents);
            SortGradesDescending(grades, numStudents);

            DisplayArray(grades, numStudents);
        }

        static int EnterGrades(int[] grades, int max)
        {
            int count = 0;
            for (int i = 0; i <= max; i++)
            {
                int num = 0;
                bool validInput = false;
                while (!validInput)
                {
                    if (count == max)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine($"The free edition supports a max of {max} grades.");
                        Console.WriteLine("Please upgrade to a full edition for unlimited number of grades.");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Press ANY key to continue.");
                        Console.ReadLine();
                        return count;
                    }
                    num = GetPositiveInt("Enter Grade: ");

                    // Check for Exit Conditions
                    if (num == 999)
                    {
                        return count;
                    }

                    if (num > 100)
                    {
                        Console.WriteLine("Invalid Value: Grade cannot be higher than 100.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                grades[i] = num;
                count++;
            }
            return count;
        }

        /* Sort our Grades with SELECTION SORT */
        static void SortGradesDescending(int[] grades, int size)
        {
            for (int scanIdx = 0; scanIdx < size - 1; scanIdx++)
            {
                int maxIdx = scanIdx;
                for (int i = scanIdx + 1; i < size; i++)
                {
                    if (grades[i] > grades[maxIdx])
                        maxIdx = i;
                }

                if (maxIdx != scanIdx)
                {
                    Swap(grades, scanIdx, maxIdx);
                }
            }
        }

        static void Swap(int[] arr, int a, int b)
        {
            int tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }

        static void DisplayArray(int[] grades, int size)
        {
            Console.WriteLine("\nGrades from Highest to Lowest: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\t " + grades[i]);
            }
            Console.WriteLine("Average: " + CalculateAverage(grades, size));
        }

        static double CalculateAverage(int[] grades, int size)
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += (double)grades[i];
            }
            return sum / size;
        }

        
        static int GetPositiveInt(string msg)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Invalid Input: Enter a non-negative value.");
                    return GetPositiveInt(msg);
                }
                return num;
            } catch(Exception ex)
            {
                Console.WriteLine("Invalid Input: Enter numbers. ");
                return GetPositiveInt(msg);
            }

        }

        static int GetPositiveInt(string msg, int max)
        {
            int num = GetPositiveInt(msg);
            if (num > max)
            {
                Console.WriteLine($"Invalid Value: Enter number lower than {max}.");
                GetPositiveInt(msg, max);
            }
            return num;
        }
    }
}
