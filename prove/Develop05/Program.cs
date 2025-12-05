using System;
using System.Diagnostics;
using System.Xml.Schema;
using Microsoft.VisualBasic;

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
        do 
        {
            int goalSelection = 0;
            activity.FileMend();
            activity= new Activity(file);
            string[][] info = activity.GoalStuff();
            Console.WriteLine($"\nyou have {score.ReadPoints()} ponts");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Shop");
            Console.WriteLine("5. Quit");
            selection = GetUserInt(1,5);
            if (selection == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("The types of goals are");
                Console.WriteLine("1. Simple Goals");
                Console.WriteLine("2. Checklist Goals");
                Console.WriteLine("3. Eternal Goals");
                Console.WriteLine("What kind of goal would you like to create?");
                goalSelection = GetUserInt(1,3);
                if (goalSelection == 1)
                {
                    activity.Create();
                }
                else if (goalSelection == 2)
                {
                    Check check = new Check(file);
                    check.Create();
                }
                else if (goalSelection == 3)
                {
                    Eternal eternal = new Eternal(file);
                    eternal.Create();
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
                Console.WriteLine("What kind of goal have you completed?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Checklist Goal");
                Console.WriteLine("3. Eternal Goal");
                goalSelection = GetUserInt(1,3);

                if (goalSelection == 1)
                {
                    Console.WriteLine("Which goal have you completed?");
                    int ab = GetUserInt(1,activity.GoalList());
                    if (info[ab-1][0] == "[]")
                    {                    
                        activity.completion(ab);
                        int points = int.Parse(info[ab-1][3]);
                        score.AddPoints(points);
                    }
                    else
                    {
                        Console.WriteLine("You have already completed this goal.");
                    }
                }
                else if (goalSelection == 2)
                {
                    Console.WriteLine("Which goal have you completed?");
                    Check check = new Check(file);
                    int ab = GetUserInt(1,activity.GoalList());
                    if (int.Parse(info[ab-1][5]) < int.Parse(info[ab-1][6])-1)
                    {                    
                        check.checkcompletion(ab);
                        int points = int.Parse(info[ab-1][3]);
                        score.AddPoints(points);
                    }
                    else if (int.Parse(info[ab-1][5]) < int.Parse(info[ab-1][6]))
                    {
                        check.checkcompletion(ab);
                        int points = int.Parse(info[ab-1][4]);
                        score.AddPoints(points);
                    }
                    else
                    {
                        Console.WriteLine("youve already completed this task.");
                    }

                }
                else if (goalSelection == 3)
                {
                    Console.WriteLine("Which goal have you completed?");
                    int ab = GetUserInt(1,activity.GoalList());
                    int points = int.Parse(info[ab-1][3]);
                    score.AddPoints(points);
                }
            }
            else if (selection == 4)
            {
                Shop shop = new Shop();
                Console.WriteLine("\nWhat would you like to buy?");
                shop.ShowShop();
                int shopSelection = GetUserInt(1,shop.ShopSize());
                shop.ChangeSelection(shopSelection);
                if (shopSelection == 1)
                {
                    if (score.ReadPoints() >= shop.GiveCost(shopSelection))
                    {
                        score.TakePoints(shop.GiveCost(shopSelection));
                        shop.Dance(2);
                    }
                    else
                    {
                        Console.WriteLine("\nyou dont have enough points");
                    }
                }
                else if (shopSelection == 2)
                {
                    if (score.ReadPoints() >= shop.GiveCost(shopSelection))
                    {
                        score.TakePoints(shop.GiveCost(shopSelection));
                        shop.Dance(10);
                    }
                    else
                    {
                        Console.WriteLine("\nyou dont have enough points");
                    }
                }

            }
        } while(selection!=5);
    }
}