
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result = 0;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation!");
            return;
        }

        Console.WriteLine("Score: " + result);
    }
}
