using System;

class Program
{
    public void f1()
    {
        Console.WriteLine("Hello World");
    }

    public void f2()
    {
        Console.WriteLine("f2 call");
    }

    public void f3()
    {
        Console.WriteLine("f3 call");
    }

    public delegate void myDelegate(); // stores the address of method

    public static void Main(string[] args)
    {
        Program obj = new Program();

        myDelegate del = new myDelegate(obj.f1);
        del();

        del += obj.f1;   // add f1 again
        del += obj.f2;   // add f2
        del -= obj.f2;   // remove f2
        del += obj.f3;   // add f3

        del(); // invoke delegate
    }
}
