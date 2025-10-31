using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("please enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");

    }
}

//Console.Read() gets single charater and returns it as an int