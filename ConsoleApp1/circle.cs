using System.Runtime.InteropServices;



class Circle
{
    //purpose of constructor is to create and initialize state
    public Circle()
    {
        Console.Write("default ");
        _radius = 0.0;
    }
    public Circle(double radius)
    {
        Console.Write("non-default ");
        SetRadius(radius);
    }
    
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
        return Math.PI * _radius * _radius;
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


        Circle myCircle2 = new Circle(100);
        Console.WriteLine(myCircle2.GetCircleArea());

    }

}