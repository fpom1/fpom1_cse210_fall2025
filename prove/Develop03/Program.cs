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