using System.Data;
using Microsoft.VisualBasic;

class Check : Activity
{
    
    public Check(string goalFile):base(goalFile)
    {
        _goalStuff = base.CsvArray(goalFile);
        _goalFile = goalFile;
        string[][] info = base.GoalStuff();
    }

    public override void Create()
    {
        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points should making progress be worth?");
        string goalPoints = Console.ReadLine();
        Console.WriteLine("How many points should completing it be worth?");
        string finalPoints = Console.ReadLine();
        Console.WriteLine("How many times should you have to complete this goal?");
        string length = Console.ReadLine();
        string goal = ($"\n ,{goalName},{goalDescription},{goalPoints},{finalPoints},0,{length}");
        File.AppendAllText(_goalFile, goal);
    }


    public void checkcompletion(int index)
    {
        string[][] info = base.GoalStuff();
        List<string> lines = File.ReadAllLines(_goalFile).ToList();
        int help = int.Parse(info[index-1][5]);
        help++;
        List<string> result = lines[index-1].Split(',').ToList();
        Console.WriteLine(result[5]);
        result[5] = help.ToString();
        lines[index-1] = string.Join(",", result);
        File.WriteAllLines(_goalFile, lines);
    }

        public override int GoalList()
    {
        int counter = 1;
        Console.WriteLine("Your goals are");
        foreach (string[] i in _goalStuff)
        {
            try
            {
            Console.WriteLine($"{counter}. {i[5]}/{i[6]} {i[1]} ({i[2]}) ");
            counter++;
            }
            catch
            {counter++;}
        }
        return counter;
    }
}

