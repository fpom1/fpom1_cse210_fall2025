using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 100);
        int guess = -99999;
        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > randomNumber)
            {
                Console.Write("Lower\n");
            }
            else if (guess < randomNumber)
            {
                Console.Write("Higher\n");
            }
            else
            {
                Console.Write("good job");
            }
        }

    }
}