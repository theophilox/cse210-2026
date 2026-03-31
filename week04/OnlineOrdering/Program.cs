using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("");

        Address address = new Address("1234 West 500 South", "Salt Lake City", "UT", "USA");
        Customer customer = new Customer("Joshua Javier", address);
        Order order = new Order(customer);
        order.AddProduct(new Product("Book", "B001", 10, 2));
        order.AddProduct(new Product("Pen", "P002", 2, 5));
        order.AddProduct(new Product("T-shirt", "T005", 10, 3));

        Console.WriteLine("~~~~~~~~~~~ORDER 1~~~~~~~~~~~");
        Console.WriteLine("");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: ${order.TotalCost()}");
        Console.WriteLine("");


        Address address2 = new Address("Hillsview Royale", "NaiC", "Cavite", "PH");
        Customer customer2 = new Customer("Charmaine Javier", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Chicken-Whole", "CH001", 25, 2));
        order2.AddProduct(new Product("Papaya", "VE003", 10, 2));
        order2.AddProduct(new Product("Ginger", "VE024", 10, 3));

        Console.WriteLine("~~~~~~~~~~~ORDER 2~~~~~~~~~~~");
        Console.WriteLine("");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
        Console.WriteLine("");
    }
}