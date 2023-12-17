using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class TacoSpices : Product
{
    private const int id = 10;
    private const string name = "Tacokrydder";
    private const string description = "tacokrydder, 3 stk";
    private const PackagingClass packaging = PackagingClass.TypeB;
    private const double price = 35;
    private const double weight = 40;
    private const double length = 10;
    private const double width = 6;
    private const double height = 1;

    public TacoSpices() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
