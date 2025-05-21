using System;

class Program
{
    static void Main(string[] args)
    {
        // Product Constructor:
        // Product(string productName, int productID, int quantity, float price)

        // Address Constructor:
        // Address(string street, string city, string province, string country, bool isInUS = true)

        // Order 1

        Address address1 = new Address("50 W North Temple", "Salt Lake City", "Utah", "USA");
        Customer customer1 = new Customer("The Church of Jesus Christ of Latter-day Saints", address1);
        List<Product> products1 = new List<Product>()
        {
            new Product("Book of Mormon", 1820, 4000, 6.00f),
            new Product("Solid Gold", 0024, 20, 75.48f),
            new Product("Nauvoo Temple", 2024, 1, 12f)
        };
        Order order1 = new Order(products1, customer1);

        Console.Clear();
        Console.WriteLine("---- ORDER 1 ----");
        Console.WriteLine($"{order1.GetPackingLabel()}-------------");
        Console.WriteLine($"{order1.GetShippingLabel()}\n---------------");
        Console.WriteLine($"Total order price: {order1.GetTotalCost()}");

        // Order 2

        Address address2 = new Address("837 Rich Person Ln", "Dubai", "Dubai", "United Arab Emirates", false);
        Customer customer2 = new Customer("Some Rich Guy", address2);
        List<Product> products2 = new List<Product>()
        {
            new Product("Baby Jet Ski", 8473, 3, 350.29f),
            new Product("Parachute", 0001, 2, 58.01f),
            new Product("Hot Wheels Bugatti", 7878, 5, 6.49f)
        };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("---- ORDER 2 ----");
        Console.WriteLine($"{order2.GetPackingLabel()}-------------");
        Console.WriteLine($"{order2.GetShippingLabel()}\n---------------");
        Console.WriteLine($"Total order price: {order2.GetTotalCost()}");

    }
}