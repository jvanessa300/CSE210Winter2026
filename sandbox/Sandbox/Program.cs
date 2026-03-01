using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
  
    }

    static void main(string[] args)
    {
        Greeting();

        int total = AddNumbers(10, 20);

        Console.WriteLine(total);

    }

    public static int AddNumbers(int n1, int n2)
    {
        return n1 + n2;
    }

    public static void Greeting()
    {
        Console.WriteLine("Hello Bob");
    }
}

// NOTES //





  //     int age;

    //     Console.Write("Please input your age: ");
    //     // string response = Console.ReadLine();
    //    // age = int.Parse(response);    

    //     age = int.Parse(Console.ReadLine());

    //     Console.WriteLine($"Your age is: {age}");

    //     if (age <= 100)
    //     {
    //         Console.WriteLine("You are cool.");
    //     }
    //     else if (age <= 150)
    //     {
    //         Console.WriteLine("You are sort of cool.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Wow, You've had a lot of Birthdays!");
    //     }


 // for(int i = 0; i < 10; i += 3)
    // {
    //     Console.WriteLine(i);
    // }

    // int y = 10
    // int z = ++y;
    // Console.WriteLine(y);
    // Console.WriteLine(z);

    // for(int i = 100000; i >= -100000; i -= 100000)
    // {
    //     Console.WriteLine(i);
    // }

//     bool done = false;
    
//     while (! done)
// {
//     Console.WriteLine("Please input age: ");
//     int age = int.Parse(Console.ReadLine());
//     if (age >= 0 && age <= 125)
//     {
//         done = true;
//         Console.WriteLine("Thank you.");
//     }
//     else
//     {
//         Console.WriteLine("Please input a valid age.");
//     }
// }

//         for(int i = 0; i < 10; i += 3)
//     {
//         Console.WriteLine(i);
//     }

//     int y = 10
//     int z = ++y;
//     Console.WriteLine(y);
//     Console.WriteLine(z);

//     bool done; 
//     do
// {
//     Console.WriteLine("Please input age: ");
//     int age = int.Parse(Console.ReadLine());
//     if (age >= 0 && age <= 125)
//     {
//         done = true;
//         Console.WriteLine("Thank you.");
//     }
//     else
//     {
//         done = false;
//         Console.WriteLine("Please input a valid age.");
//     }
// } while(! done);
    
// }

    //   List<int> myData = new List<int>();
    // myData.Add(10);
    // myData.Add(11);
    // myData.Add(12);
    // myData.Add(13);
    // myData.Add(14);
    // myData.Add(15);
    // Console.WriteLine(myData.Count);

    // foreach(int i in myData)
    //     {
    //         Console.WriteLine(i);
    //     }

    // List<string> myFriends = ["Bob", "Betty", "Jenny"];
    // myFriends.Add("Bubba");
    //  myFriends.Add("23423");

    //  foreach(string friend in myFriends)
    //     {
    //         Console.WriteLine(friend);
    //     }
