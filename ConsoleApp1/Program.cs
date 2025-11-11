using System.Runtime.InteropServices;



class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid radius");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }

    }

    public double GetCircleArea()
    {
        return 3.141592 * _radius * _radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello world");
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetCircleArea());

    }

}