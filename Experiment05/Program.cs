using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Asynchronous Programming Example\n");

        Console.WriteLine("Program started");

        await DoWork();   // calling async method

        Console.WriteLine("Program finished");

        Console.ReadLine();
    }

    static async Task DoWork()
    {
        Console.WriteLine("Task started...");

        await Task.Delay(3000);   // non-blocking delay (3 seconds)

        Console.WriteLine("Task completed after delay");
    }
}