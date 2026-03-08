using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Arithmetic Operations Program");

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        int add = a + b;
        int sub = a - b;
        int mul = a * b;
        int div = a / b;

        Console.WriteLine("Addition = " + add);
        Console.WriteLine("Subtraction = " + sub);
        Console.WriteLine("Multiplication = " + mul);
        Console.WriteLine("Division = " + div);

        Console.ReadLine();
    }
}