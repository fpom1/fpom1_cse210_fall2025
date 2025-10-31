using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        string firstName;
        string lastName;

        Console.Write("please enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");

        int x = 10;
        if (x == 10 || x == 11 && x == 12 && x != 14)
        // (x == 10 or x == 11 and x == 12 and x not= 14)
        {
            Console.WriteLine("x is 10");
            Console.WriteLine("x is 10");
        }
        else if (x == 123313)
        {
            Console.WriteLine("hello friend");
        }
    }
}
