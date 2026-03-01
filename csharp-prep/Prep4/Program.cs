using System;
using System.ComponentModel;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


    List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    int number = -1;

    while (number != 0)
    {
        Console.Write("Enter number: ");
        string userResponse = Console.ReadLine();
        number = int.Parse(userResponse);

        if (number != 0)
        {
            numbers.Add(number);
        }
    }

    int sum = 0;

    foreach (int wholeNumber in numbers)
        {
            sum += wholeNumber;
        }

        Console.WriteLine($"The sum is: {sum}");

    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int largest = numbers[0];

    foreach (int wholeNumber in numbers)
        {
            if(number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The maximum number is: {largest}");
    }

}