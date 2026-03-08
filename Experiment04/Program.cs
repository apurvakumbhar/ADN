using System;

class Program
{
    // Delegate declaration
    public delegate int Operation(int a, int b);

    static void Main(string[] args)
    {
        Console.WriteLine("Demonstration of Delegates and Lambda Expressions\n");

        Console.Write("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        // Using delegate with lambda expression
        Operation add = (a, b) => a + b;
        Operation sub = (a, b) => a - b;
        Operation mul = (a, b) => a * b;
        Operation div = (a, b) => a / b;

        Console.WriteLine("Addition = " + add(x, y));
        Console.WriteLine("Subtraction = " + sub(x, y));
        Console.WriteLine("Multiplication = " + mul(x, y));
        Console.WriteLine("Division = " + div(x, y));

        Console.ReadLine();
    }
}