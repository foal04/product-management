// Program.cs

class Program
{
    static void Main()
    {
        Product laptop = new Product { ProductId = 1, ProductName = "Laptop", Price = 1200 };
        Product smartphone = new Product { ProductId = 2, ProductName = "Smartphone", Price = 800 };

        Inventory inventory = new Inventory();
        inventory.AddProduct(laptop);
        inventory.AddProduct(smartphone);

        inventory.DisplayInventory();
    }
}
