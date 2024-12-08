using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        char op;
        double num1, num2, result;

        Console.WriteLine("Simple Calculator");

        while (true)
        {
            Console.WriteLine("\nEnter an operator (+, -, *, /) or 'm' to exit: ");
            string input = Console.ReadLine(); // Read input as a string

            // Check if the user wants to exit
            if (input == "m")
            {
                Console.WriteLine("Exiting calculator...");
                break;
            }

            // Convert the operator to a char
            if (input.Length == 1)
            {
                op = input[0];
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid operator.");
                continue;
            }

            Console.WriteLine("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid number. Please try again.");
                continue;
            }

            Console.WriteLine("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid number. Please try again.");
                continue;
            }

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: {0}", result);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
