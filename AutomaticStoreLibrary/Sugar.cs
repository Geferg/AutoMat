using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary;
internal class Sugar : Product
{
    private const int id = 3;
    private const string name = "Sukker";
    private const string description = "Stor pose sukker";
    private const PackagingClass packaging = PackagingClass.TypeC;
    private const double price = 25;
    private const double weight = 1000;
    private const double length = 10;
    private const double width = 15;
    private const double height = 20;

    public Sugar() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
