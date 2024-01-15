// Inventory.cs

using System;
using System.Collections.Generic;

public class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var product in products)
        {
            product.DisplayProduct();
        }
    }
}
