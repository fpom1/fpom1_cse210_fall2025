using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;



public class FileManagement
{
    //save to a file
    public static void SaveStringToFile(string text, string filename)
    {
        File.AppendAllText(filename, text + Environment.NewLine);
    }
    //read and print file
    public static void ReadAndPrintFile(string filename)
    {
        string fileContent = File.ReadAllText(filename);
        Console.WriteLine(fileContent);
    }
}

public class Entry
{
    private readonly List<string> entries;

    public Entry()
    {
        entries = new List<string>{};
    }
    public List<string> CreateNewEntry()
    {
        DateTime currentDateAndTime = DateTime.Now;
        string entry = Console.ReadLine();
        entries.Add($"{entry},{currentDateAndTime}");
        return entries;
    }

    public void PrintEntries()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{entries[i]}");
        }
    }

    public string GetEntry()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            return entries[i];
        };
        return null;
    }

    public void ResetEntries()
    {
        List<string> entries = [];
    }

}


public class PromptGenerator
{
    private readonly List<string> prompts;
    private readonly Random _random;

    public PromptGenerator()
    {
        // Initialize the list of strings here
        prompts = new List<string>
        {
            "How was your day?",
            "Who did you meet today?",
            "How many bugs did you see today?",
            "What did you have for lunch?",
            "How do you feel?",
            "What did you achive today?",
        };

        _random = new Random();
    }

    //return random promt
    public string GetPrompt()
    {
        int index = _random.Next(prompts.Count);
        return prompts[index];
    }

}


class Program
{

    static void Main()
    {

        string filePath = "/Users/codyjensen/Documents/college/2025 Fall/Programming with Classes/fpom1_cse210_fall2025/prove/Develop02/journal.txt";
        var generator = new PromptGenerator();
        var entry = new Entry();
        int selection = -999;
        while (selection != 0)
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine("1: read journal history");
            Console.WriteLine("2: get prompt and create entry");
            Console.WriteLine("3: read current entries");
            Console.WriteLine("4: save current entry to journal");
            Console.WriteLine("0: exit");
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                FileManagement.ReadAndPrintFile(filePath);
            }
            else if (selection == 2)
            {
                Console.WriteLine(generator.GetPrompt());
                entry.CreateNewEntry();
            }
            else if (selection == 3)
            {
                entry.PrintEntries();
            }
            else if (selection == 4)
            {
                FileManagement.SaveStringToFile(entry.GetEntry(),filePath);
                entry.ResetEntries();
            }

        }

    }
}



