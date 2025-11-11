class Program
{
    static void Main()
    {
        Console.WriteLine("Hello world");
    }

}

class Cirle
{
    public double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetCircleArea()
    {
        return 3.141592 * _radius *_radius;
    }
}