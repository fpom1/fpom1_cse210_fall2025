public class Numeral
{
    public int Difficulty()
    {
        int userNumber;
        bool isValidInput = false;
        do
        {
            Console.Write("Please enter an number for your difficulty: ");
            string input = Console.ReadLine();
            isValidInput = int.TryParse(input, out userNumber);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!isValidInput);
        Console.WriteLine($"difficulty: {userNumber}");
        return userNumber;
    }
}