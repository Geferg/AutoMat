using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Fish : Product
{
    private const int id = 7;
    private const string name = "Fisk";
    private const string description = "Fersk laksfilet, 300g";
    private const PackagingClass packaging = PackagingClass.TypeA;
    private const double price = 75;
    private const double weight = 300;
    private const double length = 20;
    private const double width = 15;
    private const double height = 5;

    public Fish() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
