using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary.Products;
internal class DeliChicken : Product
{
    private const int id = 3;
    private const string name = "Kyllingpålegg";
    private const string description = "Kyllingpålegg i skiver, 200g";
    private const PackagingClass packaging = PackagingClass.TypeB;
    private const double price = 35;
    private const double weight = 200;
    private const double length = 18;
    private const double width = 12;
    private const double height = 8;

    public DeliChicken() : base(id, name, description, packaging, price, weight, length, width, height) { }
}
