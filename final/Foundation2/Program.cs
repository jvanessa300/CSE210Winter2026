using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Vanessa Jimenez", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "P100", 4.50, 3));
        order1.AddProduct(new Product("Pens", "P101", 2.00, 5));
        order1.AddProduct(new Product("Backpack", "P102", 35.00, 1));

        Address address2 = new Address("45 Queen Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Carter", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Water Bottle", "P200", 15.00, 2));
        order2.AddProduct(new Product("Yoga Mat", "P201", 25.00, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}