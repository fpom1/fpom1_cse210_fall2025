using System;
using System.Diagnostics;

class Program
{

    //function

    static void testValues(int x, float y, double z)
    {
        Console.WriteLine($"the values are {x} {y} {z}");
    }
    static void Main(string[] args)
    {
        List<int> ints = [1,2,3,4,5];
        Console.WriteLine(ints);
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("please enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");

        int x;
        x = 10;

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

        Console.WriteLine($"{x},{++x},{x++},{x}");
        Console.WriteLine(Math.Pow(2, 6));

        // loops

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"the value of i is {i}");
        }
        for (int i = 0; i < 1001; i += 10)
        {
            Console.WriteLine($"the value of i is {i}");
        }

        //while
        bool done = false;

        while (!done)
        {
            Console.Write("input your age");
            int age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 130)
            {
                done = true;
                Console.WriteLine($"super age {age}");
            }
        }

        done = false;
        //do while will always run at least once
        do
        {
            Console.Write("input your age");
            int age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 130)
            {
                done = true;
                Console.WriteLine($"super age {age}");
            }
        } while (!done);

        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(55);
        numbers.Add(55);
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        testValues(10, (float)10.32, 10.12345);
    }
}

//Console.Read() gets single charater and returns it as an int