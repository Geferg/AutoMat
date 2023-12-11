using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary;
internal class TomatoCanned : Product
{
    private const int id = 2;
    private const string name = "Tomat";
    private const string description = "Tomat på boks";
    private const PackagingClass packaging = PackagingClass.TypeA;
    private const double price = 19;
    private const double weight = 300;
    private const double length = 8;
    private const double width = 8;
    private const double height = 12;

    public TomatoCanned() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
