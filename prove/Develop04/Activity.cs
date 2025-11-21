public class Activity
{
    public Activity()
    {}
    protected string Intro()
    {
        return "Welcome to the _ activity";
    }
    protected string Ending()
    {
        return("you have completed the _ activity \nWell done!\n");
    }
    protected int GetUserInt()
    {
        int userNumber;
        bool isValidInput = false;
        do
        {
            string input = Console.ReadLine();
            isValidInput = int.TryParse(input, out userNumber);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!isValidInput);
        return userNumber;
    }
    protected void Loading(int duration)
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
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
