using System;
using System.Diagnostics;

class Program
{

    static int GetUserInt(int min, int max)
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
            if (userNumber < min || userNumber > max)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                isValidInput = false;
            }
        } while (!isValidInput);
        return userNumber;
    }
    static void Main()
    {
        string file = "/Users/codyjensen/Documents/college/2025 Fall/Programming with Classes/fpom1_cse210_fall2025/prove/Develop05/goals.csv";
        int selection = 0;
        Activity activity= new Activity(file);
        Score score = new Score();
        while (selection != 6)
        {
            Console.WriteLine($"\nyou have {score.ReadPoints()} ponts");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            selection = GetUserInt(1,6);
            if (selection == 1)
            {
                Console.WriteLine("");
                int goalSelection = 0;
                Console.WriteLine("The types of goals are");
                Console.WriteLine("1. Simple Goals");
                Console.WriteLine("2. Checklist Goals");
                Console.WriteLine("3. Eternal Goals");
                Console.WriteLine("What kind of goal would you like to create?");
                goalSelection = GetUserInt(1,3);
                if (goalSelection == 1)
                {
                    activity.Creation();
                }
                else if (goalSelection == 2)
                {
                    
                }
                else if (goalSelection == 3)
                {
                    
                }
            }
            else if (selection == 2)
            {
                Console.WriteLine("");
                activity.GoalList();
            }
            else if (selection == 3)
            {
                Console.WriteLine("");
                score.AddPoints(25);
            }
            else if (selection == 4)
            {
                Console.WriteLine("");
            }
            else if (selection == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("hi");
            }

        }

        activity.completion(1);
    }
}