

using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{


    public static void ProcessPerson(Person person)
    {
        Console.Write(person.GetPersonInformation());

        // Console.WriteLine($", My Salary is: {person.GetSalary()}");
    }
   public static void Main(string[] args)
    {
        Person person = new Person("Bob", "Ross", 55, 195);

        // Console.WriteLine(person.GetPersonInformation());

        Docotor, myDoctor, myDoctor2;


        myDoctor = new Doctor("Ax", "Bob","Budge", 75, 210);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        myDoctor2 = new Doctor("Knife", "Bobby", "Billy", 75, 210);

         Police myPolice = new Police("Gun", "Lance", "Bob", 43, 198);

        myPolice.SetWeight(myPolice.GetWeight() + 5);
        myPolice.SetAge(myPolice.GetAge() + 1);

        List<Person> myPeople = new List<Person>();
        myPeople.Add(person);
        myPeople.Add(myDoctor);
        myPeople.Add(myDoctor2);
        myPeople.Add(myPolice);

        foreach(Person tempPerson in myPeople)
        {
            // Console.WriteLine(tempPerson.GetPersonInformation());
            ProcessPerson(tempPerson);
        }
    }

   
}