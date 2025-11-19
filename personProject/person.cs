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
        SetAge(age);
        SetWeight(weight);
    }

    public void SetAge(int age)
    {
        if (age > 0 && age <150)
        {
            _age = age;
        }
        else
        {
            _age = 0;
        }
    }

    public void SetWeight(int weight)
    {
        if (weight > 0 && weight <500)
        {
            _weight = weight;
        }
        else
        {
            _weight = 0;
        }
    }

    protected string GetPersonInformation()
    {
        return ($"{_firstName} {_lastName}, age: {_age}, weight: {_weight}");
    }

}