class Eternal : Activity
{
    
    public Eternal(string goalFile):base(goalFile)
    {
        _goalStuff = base.CsvArray(goalFile);
        _goalFile = goalFile;
    }

    public override void Create()
    {
        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points should it be worth?");
        string goalPoints = Console.ReadLine();
        string goal = ($"\n ,{goalName},{goalDescription},{goalPoints}");
        File.AppendAllText(_goalFile, goal);
    }

}