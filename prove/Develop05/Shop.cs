using System.ComponentModel.Design;

class Shop
{
    private int _selection;
    private List<string> _items;
    private List<int> _costs;

    public Shop()
    {
        _selection = -100;
        _items = new List<string>();
        _costs = new List<int>();
        _costs.Add(0);
        _items.Add("0. Exit Shop");
        _costs.Add(500);
        _items.Add($"1. Dance [{_costs[1]} points]");
        _costs.Add(1000);
        _items.Add($"2. Longer Dance [{_costs[2]} points]");
    }

    public int GiveCost(int selection)
    {
        return _costs[selection];
    }
    public void ChangeSelection(int selection)
    {
        _selection = selection;
    }
    public void Dance(int duration)
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
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Clear();
            Console.WriteLine(frames[frameIndex]);
            frameIndex = (frameIndex + 1) % frames.Length;
            Thread.Sleep(200);
        }

        Console.Clear();
    }
    public void ShowShop()
    {
        foreach (string item in _items)
        {
            Console.WriteLine(item);
        }
    }
    public int ShopSize()
    {
        return _items.Count;
    }

}