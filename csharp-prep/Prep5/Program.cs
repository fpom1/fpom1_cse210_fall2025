using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("welcome to the program");
    }
    static string promptUserName()
    {
        Console.WriteLine("please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptNumber()
    {
        Console.WriteLine("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int promptYear()
    {
        Console.WriteLine("please enter your birth year: ");
        int year = int.Parse(Console.ReadLine());
        return year;
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayResult(string name, int year, int square)
    {
        int age = 2025 - year;
        Console.WriteLine($"{name}, the square of your number is {square} ");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = promptUserName();
        int number = promptNumber();
        int birthYear = promptYear();
        int square = squareNumber(number);
        displayResult(userName, birthYear, square);
    }
}