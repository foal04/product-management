// Product.cs

using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: ${Price:F2}\n");
    }
}
