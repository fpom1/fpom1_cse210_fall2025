using System.ComponentModel.Design;
using System.Data.SqlTypes;

class Shop
{
    private int _selection;
    private List<string> _items;
    private List<int> _costs;
    Score score = new Score();
    List<Action> _actions;
    List<string> _affirmations;
    Random _random = new Random();
    public Shop()
    {
        _selection = -100;
        _items = new List<string>();
        _costs = new List<int>();
        _actions = new List<Action>();
        _affirmations = [
            "You are cool",
            "I Love you",
            "You're the best"
        ];
        _costs.Add(0);
        _items.Add("0. Exit Shop");
        _actions.Add(ExitShop);
        _costs.Add(500);
        _items.Add($"1. Dance [{_costs[1]} points]");
        _actions.Add(Dance);

        _costs.Add(1000);
        _items.Add($"2. Longer Dance [{_costs[2]} points]");
        _actions.Add(LongDance);

        _costs.Add(200);
        _items.Add($"3. Ball Bounce [{_costs[3]} points]");
        _actions.Add(BounceBall);

        _costs.Add(100);
        _items.Add($"4. Recieve affirmation [{_costs[4]} points]");
        _actions.Add(Affirmation);
    }

    public void purchase()
    {   
        Console.Clear();
        if (score.ReadPoints() >= _costs[_selection])
        {
            _actions[_selection]();
            score.TakePoints(_costs[_selection]);
        }
        else
        {
            Console.WriteLine("You dont have enough points.");
        }

    }
    public void ChangeSelection(int selection)
    {
        _selection = selection;
    }
    public int Shoppe()
    {
        foreach (string item in _items)
        {
            Console.WriteLine(item);
        }
        return _items.Count;
    }
    private void ExitShop()
    {
        Console.WriteLine("Exiting shop\n");
    }
    private void Dance()
    {
        string[] frames = new string[]
        {
            @"  \(^_^)/ 
     |     
    / \    ",

            @"   (^_^)> 
     |     
    / \    ",

            @"  <(^_^)> 
     |     
    / \    ",

            @"  <(^_^)/ 
     |     
    / \    "
        };

        int frameIndex = 0;
        DateTime end = DateTime.Now.AddSeconds(2);

        while (DateTime.Now < end)
        {
            Console.Clear();
            Console.WriteLine(frames[frameIndex]);
            frameIndex = (frameIndex + 1) % frames.Length;
            Thread.Sleep(200);
        }

        Console.Clear();
    }
    private void LongDance()
    {
        string[] frames = new string[]
        {
            @"  \(^_^)/ 
     |     
    / \    ",

            @"   (^_^)> 
     |     
    / \    ",

            @"  <(^_^)> 
     |     
    / \    ",

            @"  <(^_^)/ 
     |     
    / \    "
        };

        int frameIndex = 0;
        DateTime end = DateTime.Now.AddSeconds(8);

        while (DateTime.Now < end)
        {
            Console.Clear();
            Console.WriteLine(frames[frameIndex]);
            frameIndex = (frameIndex + 1) % frames.Length;
            Thread.Sleep(200);
        }

        Console.Clear();
    }
    private void BounceBall()
    {
        const int height = 10;     
        const int frameDelay = 80;  
        int pos = 0;               
        int direction = 1;         

        DateTime end = DateTime.Now.AddSeconds(5);

        while (DateTime.Now < end)
        {
            Console.Clear();

            for (int i = 0; i < height; i++)
            {
                if (i == pos)
                    Console.WriteLine("   o"); 
                else
                    Console.WriteLine();        
            }
            pos += direction;
            if (pos == 0 || pos == height - 1)
                direction *= -1;
            Thread.Sleep(frameDelay);
        }
    }
    private void Affirmation()
    {
        Console.WriteLine($"{_affirmations[_random.Next(_affirmations.Count)]}");
    }

    
}