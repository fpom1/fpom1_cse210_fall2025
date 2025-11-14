using System;

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
        _checker = ModifyIndices();
    }

        private List<int> GetIndices()
    {
        List<string> wordList = _words;
        List<int> indices = Enumerable.Range(0, wordList.Count).ToList();
        return indices;
    }

        public List<int> ModifyIndices()
    {
        Random random = new Random();
        int removal = 2;
        while (removal != 0)
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
        List<string> modifiedList = [];
        List<string> words = _words;

        foreach (var item in words.Select((value, i) => new { i, value }))
        {
            var index = item.i;
            if (_checker.Contains(index))
            {
                modifiedList.Add(words[index]);
            }
            else
            {
                modifiedList.Add("____");
            }
        }

        string modifedVerse = string.Join(" ", modifiedList);
        return modifedVerse;
    }

}
public class Reference
{
    private string _reference;
    private string _book;
    private string _chapter;
    private string _verses;
    public Reference()
    {
        _book = "";
        _chapter = "";
        _verses = "";
    }
    public Reference(string input)
    {
        _reference = input;
        _book = GetBook();
        _chapter = GetChapter();
        _verses = GetVerses();
    }
    private string GetBook()
    {
        List<string> wordList = _reference.Split(" ").ToList();
        return wordList[0];
    }
    private string GetChapter()
    {
        List<string> wordList = _reference.Split(" ").ToList();
        List<string> numbers = wordList[1].Split(":").ToList();
        return numbers[0];
    }
    private string GetVerses()
    {
        List<string> wordList = _reference.Split(" ").ToList();
        List<string> numbers = wordList[1].Split(":").ToList();
        return numbers[1];
    }
    public string ReReference()
    {        
        List<string> numbs = [_chapter,_verses];
        string numbers = string.Join(":", numbs);
        List<string> full = [_book,numbers];
        string reRef = string.Join(" ", full);
        return reRef;
    }
}
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
        string reference = "John 3:16";
        string sentence = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";

        Console.WriteLine("Press enter to hide more words.");
        Console.WriteLine("Type quit to quit.");
        Console.WriteLine("");
        Reference reference1= new Reference(reference);
        string Re = reference1.ReReference();
        Words words= new Words(sentence);
        Scriptural scriptural= new Scriptural(words.StringToList());
        Console.WriteLine($"{Re}\n{sentence}");
        string selector = Console.ReadLine();

        while (selector != "quit")
        {
            if (selector == "")
            {
                Console.WriteLine($"{Re}\n{scriptural.ModifedVerse()}");
                selector = Console.ReadLine();
                if (scriptural.ModifyIndices().Count() == 0)
                {
                    Console.WriteLine($"{Re}\n{scriptural.ModifedVerse()}");
                    selector = "quit";
                }
            }
            else
            {
                Console.WriteLine($"{Re}\n{scriptural.ModifedVerse()}");
                selector = Console.ReadLine();
            }
        }

    }

}