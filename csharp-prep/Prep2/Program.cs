using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        int grade;

        Console.Write("Please enter grade percentage: ");

        grade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your grade is: {grade}");

        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the Course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do better next time.");
        }

    }
}