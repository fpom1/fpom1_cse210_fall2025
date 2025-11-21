using System;
using System.Runtime.Serialization;

class Program
{
    static int GetUserInt()
    {
        int userNumber;
        bool isValidInput = false;
        do
        {
            string input = Console.ReadLine();
            isValidInput = int.TryParse(input, out userNumber);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!isValidInput);
        return userNumber;
    }
    static void Main(string[] args)
    {

        int selection = 0;

        while(selection != 4 )
        {
            Console.WriteLine("Please select an activity");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            selection = GetUserInt();
            Console.WriteLine("");
            if (selection == 1)
            {
                Breathe breathe = new Breathe();
                breathe.BreatheLoading();
                breathe.BreatheIntro();
                breathe.BreatheLoading();
                Console.WriteLine("How many seconds would you like this activity to be?");
                int duration = GetUserInt();
                Console.WriteLine("Ready\n");
                breathe.BreatheLoading();
                breathe.BreatheTimer(duration);
                breathe.BreatheLoading();
                Console.WriteLine();
                breathe.BreatheEnding();
            }
            else if (selection == 2)
            {
                Reflect reflect = new Reflect();
                reflect.ReflectIntro();
                reflect.ReflectLoading();
                Console.WriteLine("How many seconds would you like this activity to be?");
                int duration = GetUserInt();
                Console.WriteLine("Ready\n");
                reflect.ReflectLoading();
                reflect.Reflection(duration);
                reflect.ReflectLoading();
                Console.WriteLine();
                reflect.ReflectEnding();
            }
            else if (selection == 3)
            {
                
            }
            else if (selection == 4)
            {
                Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Invalid selection\n");
            }
        }
    }
}