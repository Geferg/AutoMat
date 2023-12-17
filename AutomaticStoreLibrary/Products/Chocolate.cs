using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Chocolate : Product
{
    private const int id = 6;
    private const string name = "Sjokolade";
    private const string description = "Melkesjokolade, 100g";
    private const PackagingClass packaging = PackagingClass.TypeA;
    private const double price = 40;
    private const double weight = 100;
    private const double length = 15;
    private const double width = 7;
    private const double height = 1;

    public Chocolate() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
