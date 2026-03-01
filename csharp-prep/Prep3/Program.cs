using System;

class Program
{
    static void Main(string[] args)
    {
     
        Console.WriteLine("Hello Prep3 World!");

         Console.Write("What is the magic number? ");
    
        string magicText = Console.ReadLine();
        int magicNumber = int.Parse(magicText);
        

        Console.Write("What is your guess? ");
        string guessText = Console.ReadLine();
        int guess = int.Parse(guessText);

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
    
        Console.WriteLine("You guessed it!");

    }

}