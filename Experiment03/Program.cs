using System;

class Program
{
    static void Main(string[] args)
    {
        // S - Single Responsibility Principle
        Console.WriteLine("S - Single Responsibility Principle (SRP)");
        Console.WriteLine("Definition: A class should have only one responsibility.\n");

        Student s = new Student("Apurva");
        StudentPrinter printer = new StudentPrinter();
        printer.Print(s);


        // O - Open Closed Principle
        Console.WriteLine("\nO - Open Closed Principle (OCP)");
        Console.WriteLine("Definition: A class should be open for extension but closed for modification.\n");

        IAnimal dog = new Dog();
        IAnimal cat = new Cat();
        dog.Sound();
        cat.Sound();


        // L - Liskov Substitution Principle
        Console.WriteLine("\nL - Liskov Substitution Principle (LSP)");
        Console.WriteLine("Definition: A child class should replace parent class without breaking the program.\n");

        IAnimal animal = new Dog();
        animal.Sound();


        // I - Interface Segregation Principle
        Console.WriteLine("\nI - Interface Segregation Principle (ISP)");
        Console.WriteLine("Definition: A class should not be forced to implement methods it does not use.\n");

        Human h = new Human();
        h.Walk();


        // D - Dependency Inversion Principle
        Console.WriteLine("\nD - Dependency Inversion Principle (DIP)");
        Console.WriteLine("Definition: Depend on interfaces, not concrete classes.\n");

        Button button = new Button(new Bulb());
        button.Press();

        Console.ReadLine();
    }
}


// SRP Example
class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }
}

class StudentPrinter
{
    public void Print(Student s)
    {
        Console.WriteLine("Student Name: " + s.Name);
    }
}


// OCP + LSP Example
interface IAnimal
{
    void Sound();
}

class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}


// ISP Example
interface IWalk
{
    void Walk();
}

interface IFly
{
    void Fly();
}

class Human : IWalk
{
    public void Walk()
    {
        Console.WriteLine("Human walks");
    }
}


// DIP Example
interface ISwitch
{
    void On();
}

class Bulb : ISwitch
{
    public void On()
    {
        Console.WriteLine("Bulb is ON");
    }
}

class Button
{
    ISwitch device;

    public Button(ISwitch device)
    {
        this.device = device;
    }

    public void Press()
    {
        device.On();
    }
}