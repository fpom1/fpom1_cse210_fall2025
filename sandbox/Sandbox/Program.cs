using System.Runtime.InteropServices;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = ["a", "b", "c"];
        list.Add("q");
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
    }


}
