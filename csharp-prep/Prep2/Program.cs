using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        string LetterGrade;

        Console.Write("please enter your score as a percentage.");
        answer = Console.ReadLine();
        int percent = int.Parse(answer);
        if (percent >= 90)
        {
            LetterGrade = "A";
        }
        else if (percent >= 80)
        {
            LetterGrade = "B";
        }
        else if (percent >= 70)
        {
            LetterGrade = "C";
        }
        else if (percent >= 60)
        {
            LetterGrade = "D";
        }
        else
        {
            LetterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {LetterGrade}");
    }
}

