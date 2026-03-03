using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    



    static void Main(string[] args)
    {
        Console.WriteLine("Circle");

        Circle myCircle = new Circle();

        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetRadius());
        myCircle._radius = 900;

        Circle myCircle2 = new Circle();

        myCircle2.SetRadius(9999999999);
        Console.WriteLine(myCircle2.GetRadius());

        Console.WriteLine(myCircle2.GetCircumference());

        Console.WriteLine(myCircle2.GetArea());
        Console.WriteLine(myCircle2.GetDiameter());
;  
    }

    // public static void passByValue(int a)
    // {
    //     a++;
    //     Console.WriteLine($"In the value function {a}");
    // }
    // public static void passByRef(ref int x)
    // {
    //     x ++;
    //     Console.WriteLine($"In the ref function {x}");
    // }

    // public static void passByOut(out int y)
    // {
    //     y = 10;
    // }

    // static void secondMain(string[] args)
    // {
    //     int x = 20;
    //     Console.WriteLine($"In the main 1: {x}");

    //     passByValue(x);
    //     Console.WriteLine($"Int the main 2: {x}");
    //     passByRef(ref x);
    //     Console.WriteLine($"Inthe main ref 3: {x}");

    //     int z;
    //     passByOut(out z);
    //     Console.WriteLine(z);

    // }



    // static void main(string[] args)
    // {
    //     Greeting();

    //     int total = AddNumbers(10, 20);

    //     Console.WriteLine(total);

    // }

    // public static int AddNumbers(int n1, int n2)
    // {
    //     return n1 + n2;
    // }

    // public static void Greeting()
    // {
    //     Console.WriteLine("Hello Bob");
    // }
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
