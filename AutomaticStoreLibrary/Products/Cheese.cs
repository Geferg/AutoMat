using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Cheese : Product
{
    private const int id = 9;
    private const string name = "Ost";
    private const string description = "Cheddarost, 200g";
    private const PackagingClass packaging = PackagingClass.TypeC;
    private const double price = 45;
    private const double weight = 200;
    private const double length = 10;
    private const double width = 10;
    private const double height = 3;

    public Cheese() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
