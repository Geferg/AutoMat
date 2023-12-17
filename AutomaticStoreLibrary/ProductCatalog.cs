using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticStoreLibrary;
public class ProductCatalog
{
    public List<Product> GetProducts() => products;

    private readonly List<Product> products = new();
    private readonly HashSet<int> usedIds = new();

    public ProductCatalog()
    {
        RegisterAllProducts();
    }

    private void RegisterAllProducts()
    {
        var productTypes = Assembly.GetExecutingAssembly().GetTypes()
                                   .Where(t => t.IsSubclassOf(typeof(Product)) && !t.IsAbstract);

        foreach (var type in productTypes)
        {
            Product product = (Product)Activator.CreateInstance(type);

            if(usedIds.Contains(product.Id))
            {
                throw new InvalidOperationException($"Duplicate ID found: {product.Id} for product type {type.Name}");
            }

            products.Add(product);
            usedIds.Add(product.Id);
        }
    }
}
