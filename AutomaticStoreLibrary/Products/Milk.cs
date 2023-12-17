using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Milk : Product
{
    private const int id = 1;
    private const string name = "Melk";
    private const string description = "Lettmelk, 1 liter";
    private const PackagingClass packaging = PackagingClass.TypeC;
    private const double price = 20;
    private const double weight = 1030;
    private const double length = 9;
    private const double width = 9;
    private const double height = 25;

    public Milk() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
