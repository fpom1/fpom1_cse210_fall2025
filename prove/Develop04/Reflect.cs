public class Reflect : Activity
{
    
    private readonly Random _random;
    private readonly List<string> _questions;
    private readonly List<string> _prompts;
    private string _description;
    private string _name;

    public Reflect()
    {
        _name = "reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
        _random = new Random();
    }

    public void Reflection(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        string prompt = SelectPrompt();
        Console.WriteLine(prompt);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(SelectQuestion());
            ReflectLoading();
        }

    }
    public void ReflectLoading()
    {
        base.Loading(4);
    }
    private string SelectPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string SelectQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void ReflectIntro()
    {
        string intro = base.Intro();
        string newString = intro.Replace("_", _name);
        Console.WriteLine(newString);
        Console.WriteLine(_description);
    }
    public void ReflectEnding()
    {
        string outro = base.Ending();
        string newString = outro.Replace("_", _name);
        Console.WriteLine(newString);
    }
}