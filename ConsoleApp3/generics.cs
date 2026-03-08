using System.Collections;

//ArrayList list = new ArrayList();
//list.Add(10);
//list.Add(20);
//list.Add("c#");   ----> not a type safe collection

List<int> num=new List<int>();
num.Add(10);
num.Add(20);
//class myClass<T>
//{
//    public T Data;
//}
//public void show()
//{
//    Console.WriteLine("Data");
//}
//num.Add("c#");---error

//generic in a method

//myClass <string> obj = new myClass <string>();
//obj.Data = "c#";

using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;

        int result = add(10, 20);

        Console.WriteLine("Addition: " + result);
    }
}