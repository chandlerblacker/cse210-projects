using System;

class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order("427 Country Club Ln", "Calgary", "Alberta", "Canada", "Eric Johnson");
        Product p11 = new Product("Vaccuum", 132, 37.99, 2);
        Product p12 = new Product("Apple", 18, 0.39, 15);
        o1._products.Add(p11);
        o1._products.Add(p12);

        o1.printPacking();
        o1.printShipping();
        Console.WriteLine($"Total price: ${o1.getTotalPrice()}");
        Console.WriteLine();

        Order o2 = new Order("193 Main St", "Allen", "Oklahoma", "USA", "John Smith");
        Product p21 = new Product("Banana", 27, 0.49, 10);
        Product p22 = new Product("Desk", 564, 70.99, 2);
        Product p23 = new Product("Book Set", 874, 43.99, 1);
        o2._products.Add(p21);
        o2._products.Add(p22);
        o2._products.Add(p23);

        o2.printPacking();
        o2.printShipping();
        Console.WriteLine($"Total price: ${o2.getTotalPrice()}");
    }
}