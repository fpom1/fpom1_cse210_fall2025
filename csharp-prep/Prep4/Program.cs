using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int entry = 0;
        do
        {
            Console.Write("enter a number: ");
            entry = int.Parse(Console.ReadLine());
            numbers.Add(entry);
        }
        while (entry != 0);

        numbers.RemoveAt(numbers.Count - 1);
        int sum = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();
        Console.WriteLine($"the sum is {sum}");
        Console.WriteLine($"the average is {average}");
        Console.WriteLine($"the largest is {largest}");
    }
}