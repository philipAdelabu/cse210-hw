using System;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address("34 Norway street", "Cassamblaka", "Lao", "Mexico");
        Customer customer = new Customer("John Doe", address);

        Product product1 = new Product("Book", 34, 2);
        Product product2 = new Product("Shoe", 53.20, 1);
        Product product3 = new Product("Tv", 334, 3);
        List<Product> list1 = [product1, product2, product3];

        Product prod1 = new Product("Bread", 6, 5);
        Product prod2 = new Product("Butter", 5.20, 3);
        Product prod3 = new Product("Cheese", 9.3, 7);
        List<Product> list2 = [prod1, prod2, prod3];

        Order order1 = new Order(customer, list1);
        Order order2 = new Order(customer, list2);


        Console.WriteLine("\n =========== Order 1 ====================");
        Console.WriteLine($"Package Label \n {order1.GetPackageLabel()} ");
        Console.WriteLine($"Shipping Label \n {order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():F2}");

        Console.WriteLine("\n =========== Order 2 ====================");
        Console.WriteLine($"Package Label \n {order2.GetPackageLabel()} ");
        Console.WriteLine($"Shipping Label \n {order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order2.GetTotalCost():F2}");
          
    }
}