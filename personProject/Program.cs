using System.Security.Cryptography;

class Police : Person
{
    private string _weapons = "";
    public Police (string weapons, string firstName, string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    }
}   

class Program
{
    static void Main ()
    {
        Police police1 = new Police ("gun","bob","sawyer",50,200);
        Console.WriteLine (police1.GetPoliceInformation());
        Console.WriteLine (police1.GetPersonInformation());
    }
}

