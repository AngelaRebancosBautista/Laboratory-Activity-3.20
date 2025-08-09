using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int[] gradeCounts = new int[5];

            Console.WriteLine("Enter 10 numerical grades (0-100)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Grade {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);
                    switch (grade)
                    {
                        case int n when (n >= 90):
                            gradeCounts[0]++;
                            break;
                        case int n when (n >= 80):
                            gradeCounts[1]++;
                            break;
                        case int n when (n >= 70):
                            gradeCounts[2]++;
                            break;
                        case int n when (n >= 60):
                            gradeCounts[3]++;
                            break;
                        default:
                            gradeCounts[4]++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
                    i--;
                }
            }
            Console.WriteLine("\nNumerical Grades Entered:");
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("\nGrade Distribution:");
            Console.WriteLine($"A: {gradeCounts[0]}");
            Console.WriteLine($"B: {gradeCounts[1]}");
            Console.WriteLine($"C: {gradeCounts[2]}");
            Console.WriteLine($"D: {gradeCounts[3]}");
            Console.WriteLine($"F: {gradeCounts[4]}");
        }
    }
}
            
        

             
