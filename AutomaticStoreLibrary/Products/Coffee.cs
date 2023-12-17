using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
public class Coffee : Product
{
    private const int id = 8;
    private const string name = "Kaffe";
    private const string description = "Kaffebønner, 250g";
    private const PackagingClass packaging = PackagingClass.TypeA;
    private const double price = 50;
    private const double weight = 250;
    private const double length = 10;
    private const double width = 6;
    private const double height = 4;

    public Coffee() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
