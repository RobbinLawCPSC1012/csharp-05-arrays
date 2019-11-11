using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_arrays_vs_lists_StudentManager
{
    class Program
    { 
        static void Main(string[] args)
        {
            withArrays();
            withLists();
        }

        static void withArrays()
        {
            Console.WriteLine("*** Using traditional arrays where size must be statically set at declaration ***");

            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            string[] studentNames = new string[studentCount];
            int[] studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                studentNames[i] = Console.ReadLine();

                Console.Write("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }

        static void withLists()
        {
            Console.WriteLine("*** Using dynamic arrays called lists where size is not set at declaration ***");

            List<string> studentNames = new List<string>();
            List<int> studentGrades = new List<int>();

            var adding = true;

            while(adding)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() == "n")
                    adding = false;
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }
    }
}
