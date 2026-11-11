
using System;

class Program
{
    static void Main()
    {
        Console.Write("How many grades? ");
        int numberOfGrades = Convert.ToInt32(Console.ReadLine());

        double total = 0;

        for (int i = 0; i < numberOfGrades; i++)
        {
            Console.Write("Enter grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            total += grade;
        }

        double average = total / numberOfGrades;

        Console.WriteLine("Average: " + average.ToString("F2"));

        if (average >= 3.0)
        {
            Console.WriteLine("Student passed.");
        }
        else
        {
            Console.WriteLine("Student failed.");
        }
    }
}
