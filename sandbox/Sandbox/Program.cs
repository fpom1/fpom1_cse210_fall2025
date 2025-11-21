using System.Runtime.InteropServices;
using System.Security.AccessControl;

class Program

{    static void Main()
    {
        Console.WriteLine("Hello world");

        string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = 10;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Console.Write("\b");
            Thread.Sleep(sleepTime);

        }
    }


}
