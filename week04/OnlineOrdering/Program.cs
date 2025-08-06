using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer usaCustomer = new Customer("John Doe", usaAddress);

        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Laptop", "L-456", 1200.50, 1));
        usaOrder.AddProduct(new Product("Mouse", "M-101", 25.00, 2));
        usaOrder.AddProduct(new Product("Keyboard", "K-202", 75.25, 1));

        Console.WriteLine("----- Order 1 Details (USA Customer) -----");
        Console.WriteLine(usaOrder.GetPackingLabel());
        Console.WriteLine(usaOrder.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${usaOrder.CalculateTotalCost():F2}");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("\n");

        // --- Order 2: International Customer ---
        Address internationalAddress = new Address("789 First Ave", "Lilongwe", "Central", "Malawi");
        Customer internationalCustomer = new Customer("Jane Doe", internationalAddress);

        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(new Product("Smartphone", "S-999", 899.99, 1));
        internationalOrder.AddProduct(new Product("Headphones", "H-505", 150.00, 1));

        Console.WriteLine("----- Order 2 Details (International Customer) -----");
        Console.WriteLine(internationalOrder.GetPackingLabel());
        Console.WriteLine(internationalOrder.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${internationalOrder.CalculateTotalCost():F2}");
        Console.WriteLine("-------------------------------------------");
    }
}