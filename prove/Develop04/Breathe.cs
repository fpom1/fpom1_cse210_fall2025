class Breathe : Activity
{
    private int _duration;
    private string _name;
    private string _description;
    public Breathe()
    {
        _name = "breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
        
    }
    public void BreatheIntro()
    {
        string intro = base.Intro();
        string newString = intro.Replace("_", _name);
        Console.WriteLine(newString);
        Console.WriteLine(_description);
    }
    public void BreatheLoading()
    {
        base.Loading(2);
    }
    public void BreatheTimer(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        do
        {
            int sleepTime = 1000;
            int currentLineCursor = Console.CursorTop;
            int i = 4;
            while (i > 0)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                Console.Write ($"in: {i}");
                --i;
                Thread.Sleep (sleepTime);
                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }
            i = 4;
            while (i > 0)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                string outee = ($"out:{i}");
                outee.Remove(1);
                Console.Write (outee);
                i--;
                Thread.Sleep (sleepTime);
                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }
            Console.WriteLine("");
        }while(DateTime.Now < endTime);
    }
    public void BreatheEnding()
    {
        string outro = base.Ending();
        string newString = outro.Replace("_", _name);
        Console.WriteLine(newString);
    }

    }
