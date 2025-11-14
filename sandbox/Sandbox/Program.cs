using System;
using System.Diagnostics;

class Program
{

    static void Main()
    {
        List<string> words = ["hello","hi","yo"];
        foreach (var item in words.Select((value, i) => new { i, value }))
        {
            var index = item.i;
            Console.WriteLine(index);
        }

    }

}
