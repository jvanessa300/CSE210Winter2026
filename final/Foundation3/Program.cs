using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("100 University Blvd", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture(
            "Math and Faith Lecture",
            "A discussion about the connection between mathematics and belief.",
            "April 20, 2026",
            "7:00 PM",
            address1,
            "Dr. Nelson",
            150);

        Address address2 = new Address("45 Sunset Ave", "Idaho Falls", "ID", "USA");
        Reception reception = new Reception(
            "Spring Networking Reception",
            "A reception for students and professionals to connect.",
            "May 3, 2026",
            "6:00 PM",
            address2,
            "rsvp@events.com");

        Address address3 = new Address("500 Park Lane", "Rexburg", "ID", "USA");
        OutdoorGathering outdoor = new OutdoorGathering(
            "Summer Community Picnic",
            "An outdoor picnic for families and friends.",
            "June 10, 2026",
            "1:00 PM",
            address3,
            "Sunny with light winds");

        Console.WriteLine("LECTURE");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n----------------------\n");

        Console.WriteLine("RECEPTION");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n----------------------\n");

        Console.WriteLine("OUTDOOR GATHERING");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
    }
}