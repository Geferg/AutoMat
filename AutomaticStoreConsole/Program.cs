using AutomaticStoreLibrary;
using System.Collections.Immutable;

namespace AutomaticStoreConsole;

internal class Program
{
    static void Main(string[] args)
    {
        ProductCatalog catalog = new();
        List<Product> products = catalog.GetProducts().ToList();
        List<Product> cart = new();

        Console.WriteLine("All products:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }

        Console.WriteLine("\nAdd products using the names above:");

        bool addingToCart = true;

        while (addingToCart)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("input can not be empty");
                continue;
            }

            // Check if product exists
            Product? productToAdd = products.FirstOrDefault(p => p.Name.Equals(input, StringComparison.OrdinalIgnoreCase));
            if (productToAdd == null)
            {
                Console.WriteLine("Product not found");
                continue;
            }

            // Add product
            cart.Add(productToAdd);
            Console.WriteLine($"Added {productToAdd.Name} to cart");

            // Check if end or continue adding
            Console.WriteLine("Do you want to add more products? (y/n)");
            bool readingKey = true;
            while (readingKey)
            {
                var keyPressed = Console.ReadKey(true).Key;
                if (keyPressed == ConsoleKey.Y)
                {
                    readingKey = false;
                    Console.WriteLine("y");
                    continue;
                }
                if (keyPressed == ConsoleKey.N)
                {
                    readingKey = false;
                    addingToCart = false;
                    Console.WriteLine("n");
                    continue;
                }
            }
        }

        Console.WriteLine("Cart:");
        cart.Sort();
        foreach (Product product in cart)
        {
            Console.WriteLine(product.Name);
        }

        Console.ReadKey(true);
    }
}
