using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Yoghurt : Product
{
    private const int id = 5;
    private const string name = "Yoghurt";
    private const string description = "Naturlig yoghurt, 500g";
    private const PackagingClass packaging = PackagingClass.TypeC;
    private const double price = 22;
    private const double weight = 500;
    private const double length = 12;
    private const double width = 12;
    private const double height = 8;

    public Yoghurt() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
