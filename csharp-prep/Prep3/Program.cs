using System;

class Program
{
    static void Main(string[] args)
    {
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

    }
}