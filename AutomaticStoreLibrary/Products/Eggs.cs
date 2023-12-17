using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Eggs : Product
{
    private const int id = 2;
    private const string name = "Egg";
    private const string description = "Økologiske egg, 6 stk";
    private const PackagingClass packaging = PackagingClass.TypeD;
    private const double price = 30;
    private const double weight = 360;
    private const double length = 15;
    private const double width = 10;
    private const double height = 7;

    public Eggs() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
