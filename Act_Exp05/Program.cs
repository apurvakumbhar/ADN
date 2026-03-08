using System;
using System.Threading;
using System.Threading.Tasks;

namespace EXP05
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            // Activity 01
            Console.WriteLine("Activity 01 : Run Program in Synchronous Way");

            SyncMethod1();
            SyncMethod2();


            // Activity 02
            Console.WriteLine("\nActivity 02 : Convert to Asynchronous Way");

            await AsyncMethod1();
            await AsyncMethod2();


            // Activity 03
            Console.WriteLine("\nActivity 03 : Replace Thread.Sleep with Task.Delay");

            Console.WriteLine("Waiting for 2 seconds..");
            await Task.Delay(2000);
            Console.WriteLine("Delay completed");


            // Activity 04
            Console.WriteLine("\nActivity 04 : Method Returning Task");

            await ShowMessage();

            Console.ReadLine();
        }


        // Synchronous methods
        static void SyncMethod1()
        {
            Console.WriteLine("Sync Method 1 Start");
            Thread.Sleep(2000);
            Console.WriteLine("Sync Method 1 End");
        }

        static void SyncMethod2()
        {
            Console.WriteLine("Sync Method 2 Start");
            Thread.Sleep(2000);
            Console.WriteLine("Sync Method 2 End");
        }


        // Asynchronous methods
        static async Task AsyncMethod1()
        {
            Console.WriteLine("Async Method 1 Start");
            await Task.Delay(2000);
            Console.WriteLine("Async Method 1 End");
        }

        static async Task AsyncMethod2()
        {
            Console.WriteLine("Async Method 2 Start");
            await Task.Delay(2000);
            Console.WriteLine("Async Method 2 End");
        }


        // Method returning Task
        static async Task ShowMessage()
        {
            Console.WriteLine("Task method started");
            await Task.Delay(2000);
            Console.WriteLine("Task method finished");
        }
    }
}