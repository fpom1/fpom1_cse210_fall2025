
public class Score
{
    private int _points;
    private string _file = "/Users/codyjensen/Documents/college/2025 Fall/Programming with Classes/fpom1_cse210_fall2025/prove/Develop05/Score.txt";
    public Score()
    {
        _points=ReadPoints();
    }

    public int ReadPoints()
    {
        string fileContent = File.ReadAllText(_file);
        int points = int.Parse(fileContent);
        return points;
    }
    public void AddPoints(int points)
    {
        _points = _points + points;
        WritePoints();
    }
    
    public void TakePoints(int points)
    {
        _points = _points - points;
        WritePoints();
    }

    private void WritePoints()
    {
        File.WriteAllText(_file, _points.ToString());
    }

    public void ResetPoints()
    {
        _points = 0;
        WritePoints();
    }

    
}