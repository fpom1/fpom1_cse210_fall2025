using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Tracing;



public class StringHider
{
    StringHider(string input, string wordToMask, char maskCharacter)
    {}
    public static string MaskWord(string input, string wordToMask, char maskCharacter)
    {
        // Escape the wordToMask to handle special regex characters
        string pattern = Regex.Escape(wordToMask); 
        
        // Use Regex.Replace with a MatchEvaluator to replace the matched word
        // with a string of mask characters of the same length.
        return Regex.Replace(input, pattern, m => new string(maskCharacter, m.Value.Length));
    }
}

public class Scriptural
{
    private List<string> _words;
    private List<int> _index;
    private List<int> _checker;

    public Scriptural()
    {
        _words = new List<string>();
        _index = new List<int>();
        _checker = new List<int>();
    }
    public Scriptural(List<string> input)
    {
        _words = input;
        _index = GetIndices();
        _checker = _index;
        _checker = CheckIndices();
    }

        private List<int> GetIndices()
    {
        List<string> wordList = _words;
        List<int> indices = Enumerable.Range(0, wordList.Count).ToList();
        return indices;
    }

        public List<int> CheckIndices()
    {
        Random random = new Random();
        int removal = 3;
        while (removal > 0)
        {
            if (_checker.Count > 0)
            {
                int randomIndex = random.Next(0, _checker.Count);
                removal--;
                _checker.RemoveAt(randomIndex);
            }
            else
            {
                removal = 0;
            }
        }
        return _checker;
    }

    public string ModifedVerse()
    {
        List<string> words = _words;
        string modifedVerse = string.Join(" ", words);
        return modifedVerse;
    }

}

public class Reference
{}
public class Words
{
    private string _scripture;
    private List<string> _words;

    public Words()
    {
        _scripture = "";
        _words = new List<string>();
    }
    public Words(string scrpiture)
    {
        _scripture = scrpiture;
        _words = StringToList();
    }
    public List<string> StringToList()
    {
        List<string> wordList = _scripture.Split(" ").ToList();
        return wordList;
    }

}




class Program
{
    static void Main()
    {
        string sentence = "The silly creature is very silly and filled with bees";
        string maskedSentence = StringHider.MaskWord(sentence, "apple123", '_');
        Console.WriteLine(maskedSentence); // Output: The secret password is **********.
        Words words= new Words(sentence);
        foreach (string i in words.StringToList())
        {
            Console.WriteLine(i);
        }
        Scriptural scriptural= new Scriptural(words.StringToList());
        string hat = "hat";
        while (hat != "quit")
        {
            hat = Console.ReadLine();
            Console.WriteLine(scriptural.ModifedVerse());
            foreach (int i in scriptural.CheckIndices())
            {
                Console.WriteLine(i);
            }
        }
    }

}