using System.Runtime.InteropServices;
using System.Security.AccessControl;

class Program
{
    static string[][] CsvArra(string filePath)
    {
        List<string[]> rows = new List<string[]>();
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                rows.Add(values);
            }
        }
        return rows.ToArray();
    }
    static void Main(string[] args)
    {
        string[][] hat = CsvArra("/Users/codyjensen/Documents/college/2025 Fall/Programming with Classes/fpom1_cse210_fall2025/sandbox/a.csv");
        foreach (string[] row in hat)
        {
            foreach (string values in row)
            {
                Console.WriteLine(values);
            }
        }
    }


}
