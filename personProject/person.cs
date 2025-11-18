using System.Reflection.Metadata.Ecma335;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;
    public Person(string firstName, string lastName, int age,   int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        if (age > 0 && age < 200)
        {
            _age = age;
        }
        else
        {
            _age = 0;
        }
        if (weight > 0 && weight < 300)
        {
            _weight = weight;
        }
        else
        {
            _weight = 0;
        }
    }

    public string GetPersonInformation()
    {
        return ($"{_firstName} {_lastName}, age: {_age}, weight: {_weight}");
    }

}