
using System;

class Program
{
    static void Main()
    {
        Console.Write("Convert C to F or F to C? ");
        string choice = Console.ReadLine();

        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        double result;

        if (choice == "C")
        {
            result = temperature * 1.8 + 32;
            Console.WriteLine(temperature + "°C = " + result + "°F");
        }
        else if (choice == "F")
        {
            result = (temperature - 32) / 1.8;
            Console.WriteLine(temperature + "°F = " + result + "°C");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}
