using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Delegate
    public delegate int Operation(int a, int b);

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }

    // Multicast delegate
    public delegate void ShowMessage();

    static void Message1()
    {
        Console.WriteLine("Hello Student");
    }

    static void Message2()
    {
        Console.WriteLine("Welcome to Delegates Example");
    }

    static void Main(string[] args)
    {

        // Activity 01
        Console.WriteLine("Activity 01 : Calculator using Delegates");

        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1.Add  2.Subtract  3.Multiply  4.Divide");
        Console.Write("Choose operation: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Operation op = null;

        if (choice == 1)
            op = Add;
        else if (choice == 2)
            op = Subtract;
        else if (choice == 3)
            op = Multiply;
        else if (choice == 4)
            op = Divide;
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        Console.WriteLine("Result = " + op(n1, n2));


        // Activity 02
        Console.WriteLine("\nActivity 02 : Multicast Delegate Example");

        ShowMessage msg;
        msg = Message1;
        msg += Message2;

        msg();


        // Activity 03
        Console.WriteLine("\nActivity 03 : Replace Methods with Lambda Expression");

        Operation add = (a, b) => a + b;
        Operation mul = (a, b) => a * b;

        Console.Write("Enter number 1: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition = " + add(x, y));
        Console.WriteLine("Multiplication = " + mul(x, y));


        // Activity 04
        Console.WriteLine("\nActivity 04 : Sort List using Lambda");

        List<int> numbers = new List<int>();

        Console.Write("How many numbers: ");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        numbers.Sort((a, b) => a.CompareTo(b));

        Console.WriteLine("Sorted List:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


        // Activity 05
        Console.WriteLine("\nActivity 05 : Where Delegates and Lambda are used in Industry");
        Console.WriteLine("1. Event handling");
        Console.WriteLine("2. LINQ queries");
        Console.WriteLine("3. Callback methods");
        Console.WriteLine("4. Sorting and filtering data");


        // Activity 06
        Console.WriteLine("\nActivity 06 : What is LINQ");
        Console.WriteLine("LINQ stands for Language Integrated Query.");
        Console.WriteLine("It is used to query collections like List, Array, Database in C#.");

        Console.ReadLine();
    }
}