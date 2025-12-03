class Activity
{
    
    private string[][] _goalStuff;
    public string _goalFile;

    public Activity()
    {
        _goalStuff = [];
        _goalFile = "";
    }

    public Activity(string goalFile)
    {
        _goalStuff = CsvArray(goalFile);
        _goalFile = goalFile;
    }

    static string[][] CsvArray(string filePath)
    {
        List<string[]> rows = new List<string[]>();
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                rows.Add(values);
            }
        }
        return rows.ToArray();
    }



    public void Creation()
    {
        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points should it be worth?");
        string goalPoints = Console.ReadLine();
        string goal = ($"[],{goalName},{goalDescription},{goalPoints}");
        File.AppendAllText(_goalFile, goal);
    }

    public void GoalList()
    {
        int counter = 1;
        Console.WriteLine("Your goals are");
        foreach (string[] i in _goalStuff)
        {
            Console.WriteLine($"{counter}. {i[0]} {i[1]} ({i[2]}) ");
            counter++;
        }
    }

    public void completion(int index)
    {
        List<string> lines = File.ReadAllLines(_goalFile).ToList();
        string oldChar = "[]"; // The character to be replaced
        string newChar = "[X]"; // The character to replace with

        foreach (string[] i in _goalStuff)
        {
            lines[index-1] = lines[index-1].Replace(oldChar, newChar);
            File.WriteAllLines(_goalFile, lines);
        }

    }



}