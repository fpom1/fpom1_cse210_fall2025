class Activity: Anger
{
    
    protected string[][] _goalStuff;
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

    protected string[][] CsvArray(string filePath)
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
    public override void Create()
    {
        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points should it be worth?");
        string goalPoints = Console.ReadLine();
        string goal = ($"\n[],{goalName},{goalDescription},{goalPoints}");
        File.AppendAllText(_goalFile, goal);
    }

    public override int GoalList()
    {
        int counter = 1;
        Console.WriteLine("Your goals are");
        foreach (string[] i in _goalStuff)
            try
            {
                Console.WriteLine($"{counter}. {i[5]}/{i[6]} {i[1]} ({i[2]}) ");
                counter++;
            }
            catch
            {
                Console.WriteLine($"{counter}. {i[0]} {i[1]} ({i[2]}) ");
                counter++;
            }
        return counter;
    }

    public void FileMend()
    {
        try
        {
            // Read all lines from the file
            string[] allLines = File.ReadAllLines(_goalFile);

            // Filter out empty lines (including lines with only whitespace)
            string[] nonBlankLines = allLines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            // Write the non-blank lines back to the file
            File.WriteAllLines(_goalFile, nonBlankLines);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File not found at {_goalFile}");
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
    public string[][] GoalStuff()
    {
        return _goalStuff;
    }

}