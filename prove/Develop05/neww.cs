abstract class Anger
{
    
    protected string[][] _goalStuff;
    public string _goalFile;

    public Anger()
    {
        _goalStuff = [];
        _goalFile = "";
    }

    public abstract void Create();
    public abstract int GoalList();
}