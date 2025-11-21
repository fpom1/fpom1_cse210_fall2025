class Listing : Activity
{
    private int _duration;
    private string _name;
    private string _description;
    private readonly Random _random;
    private readonly List<string> _prompts;
    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _random = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    private string SelectPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void ListingIntro()
    {
        string intro = base.Intro();
        string newString = intro.Replace("_", _name);
        Console.WriteLine(newString);
        Console.WriteLine(_description);
    }
    public void ListingLoading()
    {
        base.Loading(2);
    }   
    public void ListingEnding()
    {
        string outro = base.Ending();
        string newString = outro.Replace("_", _name);
        Console.WriteLine(newString);
    }

    public void ListingIt(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        string prompt = SelectPrompt();
        Console.WriteLine(prompt);
        ListingLoading();
        List<string> entries = [];
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            entries.Add(input);
        }
        Console.WriteLine($"you have entered {entries.Count} entries");

    }

    }
