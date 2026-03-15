using System;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Bob");

        // Console.WriteLine(myWord.GetWordString());

        // myWord.Hide();
        // Console.WriteLine(myWord.GetWordString());


        // Word myWord2 = new Word("Moroni,;:");

        // Console.WriteLine(myWord2.GetWordString());

        // myWord2.Hide();
        // Console.WriteLine(myWord2.GetWordString());

        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference,
        "And it came to pass that I, Nephi, said unto my father; I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shal prepare a way for them that they may acccomplish the thing which he commandeth them.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }

}