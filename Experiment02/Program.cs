using System;

//  CLASSES 
class Car
{
    public string color = "red";
}

class Student
{
    public string name = "Apurva";
}

class Car1
{
    public string color = "blue";
}

class Car2
{
    public string color = "green";
    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Car3
{
    public string color = "yellow";
    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Car4
{
    public string model;
    public Car4(string modelName)
    {
        model = modelName;
    }
}

class Car5
{
    private string model = "BMW";
    public string GetModel()
    {
        return model;
    }
}

class Car6
{
    public string model = "Audi";
}

class Car7
{
    protected string model = "Mercedes";
}

class Program1 : Car7
{
    public string GetModel()
    {
        return model;
    }
}

class Car8
{
    internal string model = "Lexus";
}

class Car9
{
    public string Model { get; set; }
}

//  INHERITANCE 
class Vehicle
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car10 : Vehicle
{
    public string modelName = "Mustang";
}

//  POLYMORPHISM 
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog11 : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

//  ABSTRACTION 
abstract class Animal1
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Pig1 : Animal1
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

//  INTERFACES 
interface IAnimal1
{
    void animalSound();
    void sleep();
}

class Pig2 : IAnimal1
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

interface IFirstInterface
{
    void myMethod();
}

interface ISecondInterface
{
    void myOtherMethod();
}

class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some other text...");
    }
}

//  ENUM 
enum Level
{
    Low,
    Medium,
    High
}

// main
class Program
{
    static void Main(string[] args)
    {
        // Classes & Objects
        Console.WriteLine("Classes & Objects:");
        Car car = new Car();
        Console.WriteLine(car.color);

        // Multiple Objects
        Console.WriteLine("\nMultiple Objects:");
        Student s1 = new Student();
        Student s2 = new Student();
        Console.WriteLine(s1.name);
        Console.WriteLine(s2.name);

        // Multiple Classes
        Console.WriteLine("\nMultiple Classes:");
        Car1 car1 = new Car1();
        Console.WriteLine(car1.color);

        // Class Members
        Console.WriteLine("\nClass Members:");
        Car2 car2 = new Car2();
        Console.WriteLine(car2.color);
        car2.Honk();

        // Object Methods
        Console.WriteLine("\nObject Methods:");
        Car3 car3 = new Car3();
        car3.Honk();
        Console.WriteLine(car3.color);

        // Constructor
        Console.WriteLine("\nConstructor:");
        Car4 car4 = new Car4("Mustang");
        Console.WriteLine(car4.model);

        // Access Modifiers
        Console.WriteLine("\nAccess Modifiers:");
        Car5 car5 = new Car5();
        Console.WriteLine(car5.GetModel());

        Car6 car6 = new Car6();
        Console.WriteLine(car6.model);

        Program1 p1 = new Program1();
        Console.WriteLine(p1.GetModel());

        Car8 car8 = new Car8();
        Console.WriteLine(car8.model);

        // Properties
        Console.WriteLine("\nProperties:");
        Car9 car9 = new Car9();
        car9.Model = "Toyota";
        Console.WriteLine(car9.Model);

        // Inheritance
        Console.WriteLine("\nInheritance:");
        Car10 car10 = new Car10();
        car10.honk();
        Console.WriteLine(car10.brand + " " + car10.modelName);

        // Polymorphism
        Console.WriteLine("\nPolymorphism:");
        Animal a1 = new Animal();
        Animal a2 = new Pig();
        Animal a3 = new Dog11();
        a1.animalSound();
        a2.animalSound();
        a3.animalSound();

        // Abstraction
        Console.WriteLine("\nAbstraction:");
        Pig1 pig1 = new Pig1();
        pig1.animalSound();
        pig1.sleep();

        // Interface
        Console.WriteLine("\nInterface:");
        Pig2 pig2 = new Pig2();
        pig2.animalSound();
        pig2.sleep();

        // Multiple Interfaces
        Console.WriteLine("\nMultiple Interfaces:");
        DemoClass demo = new DemoClass();
        demo.myMethod();
        demo.myOtherMethod();

        // Enum
        Console.WriteLine("\nEnum:");
        Level myLevel = Level.Medium;
        Console.WriteLine(myLevel);

        Console.ReadLine();
    }
}