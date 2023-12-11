using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary;
internal class Tortilla : Product
{
    private const int id = 1;
    private const string name = "Lefse";
    private const string description = "Lefse S 6pk";
    private const PackagingClass packaging = PackagingClass.TypeC;
    private const double price = 11;
    private const double weight = 100;
    private const double length = 30;
    private const double width = 30;
    private const double height = 2;

    public Tortilla() : base(id, name, description, packaging, price, weight, length, width, height) { }
}