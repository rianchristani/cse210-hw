using System;

class Program
{
    static void Main(string[] args)
    {

//--------- Order 1 ---------

        Address address1 = new Address("123 Main St, Apt 4B", "New York", "New York", "United States");
        Console.WriteLine(address1.DisplayAdress());

        Customer customer1 = new Customer("John Doe");
        Product product1 = new Product("Apple MacBook Air", 201, 1200, 1);
        Product product2 = new Product("iPhone 13 Pro", 202, 999, 2);
        Product product3 = new Product("Sony WH-1000XM5 Headphones", 203, 399, 3);
        Product product4 = new Product("Dell Ultrasharp Monitor", 204, 450, 2);

        Order order1 = new Order();
        order1.AddCostumer(customer1);
        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.AddProducts(product3);
        order1.AddProducts(product4);

        order1.TotalOrder(address1);
        order1.PackingLabel();
        order1.ShippingLabel(customer1, address1);

//--------- Order 2 ---------

        Address address2 = new Address("12 Oxford Street, Flat 2", "London", "Greater London", "United Kingdom");
        Console.WriteLine(address2.DisplayAdress());

        Customer customer2 = new Customer("Jane Smith");
        Product product5 = new Product("Microsoft Surface Laptop", 105, 1400, 1); // Produto 5, ID após 104
        Product product6 = new Product("Google Pixel 7 Pro", 106, 899, 2);         // Produto 6
        Product product7 = new Product("Bose Noise Cancelling Headphones", 107, 379, 1); // Produto 7
        Product product8 = new Product("HP LaserJet Printer", 108, 250, 3);        // Produto 8

        Order order2 = new Order();
        order2.AddCostumer(customer2);
        order2.AddProducts(product5);
        order2.AddProducts(product6);
        order2.AddProducts(product7);
        order2.AddProducts(product8);

        order2.TotalOrder(address2);
        order2.PackingLabel();
        order2.ShippingLabel(customer2, address2);
    }
}