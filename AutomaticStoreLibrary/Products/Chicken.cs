using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Chicken : Product
{
    private const int id = 4;
    private const string name = "Kylling";
    private const string description = "Hel kylling, fersk";
    private const PackagingClass packaging = PackagingClass.TypeA;
    private const double price = 60;
    private const double weight = 500;
    private const double length = 15;
    private const double width = 10;
    private const double height = 5;

    public Chicken() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
