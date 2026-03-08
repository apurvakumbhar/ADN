//S – Single Responsibility Principle (SRP)
//A class should do only one thing, not many.

//O – Open/Closed Principle (OCP)

//L – Liskov Substitution Principle (LSP)
//If a child class replaces a parent class,the program should not break.

//I – Interface Segregation Principle (ISP)
//Don’t force a class to use methods it doesn’t need Better to have many small interfaces than one big interface.

//D – Dependency Inversion Principle (DIP)
//Depend on interfaces, not concrete classes, High-level code should not depend on low-level code directly.

using System;

//  S – Single Responsibility 
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
        Console.WriteLine(s.Name);
    }
}

//  O – Open / Closed 
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

//  L – Liskov Substitution 
// Dog and Cat can replace IAnimal safely

//  I – Interface Segregation 
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

//  D – Dependency Inversion 
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

//  MAIN 
class Program
{
    static void Main()
    {
        // SRP
        Student s = new Student("Apurva");
        new StudentPrinter().Print(s);

        // OCP + LSP
        IAnimal animal1 = new Dog();
        IAnimal animal2 = new Cat();
        animal1.Sound();
        animal2.Sound();

        // ISP
        Human h = new Human();
        h.Walk();

        // DIP
        Button button = new Button(new Bulb());
        button.Press();

        Console.ReadLine();
    }
}
