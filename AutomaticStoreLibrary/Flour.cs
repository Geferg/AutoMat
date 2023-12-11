using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary;
internal class Flour : Product
{
    private const int id = 4;
    private const string name = "Hvetemel";
    private const string description = "Hvetemel 2kg";
    private const PackagingClass packaging = PackagingClass.TypeC;
    private const double price = 17;
    private const double weight = 2000;
    private const double length = 10;
    private const double width = 16;
    private const double height = 22;

    public Flour() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
