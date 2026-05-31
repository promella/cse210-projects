using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "Seattle",
            "WA",
            "USA");

        Customer customer1 = new Customer(
            "John Doe",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 50, 1));

        Address address2 = new Address(
            "45 King Road",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Jane Smith",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P200", 250, 2));
        order2.AddProduct(new Product("Headphones", "P201", 75, 1));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}