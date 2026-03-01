using System;

class Program
{
    static void Main(string[] args);
    {
        DisplayWelcome();
         string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int birthyear;
        PromptUserBirthYear(out birthyear);

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squaredNumber, birthyear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static void PromptUserNumber()
    {
        Console.Write("What's your favorite number?: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
{
    Console.Write("Please enter the year you were born: ");
    birthYear = int.Parse(Console.ReadLine());
}

    static int SquareNumber(int number)
{
    return number*number;
}
    static void DisplayResult(string name, int squaredNumber, int birthYear)
{
    int currentYear = DateTime.Now.Year;
    int age = currentYear - birthYear;

    Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    Console.WriteLine($"{name}, you will turn {age} this year.");
}

}