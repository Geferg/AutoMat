using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticStoreLibrary.Enums;

namespace AutomaticStoreLibrary;
public class Product : IComparable<Product>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    /// <summary>
    /// Packaging class describing the resilience of the packaging
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item>
    /// Type A: very resilient
    /// </item>
    /// <item>
    /// Type B: some resilience
    /// </item>
    /// <item>
    /// Type C: fragile
    /// </item>
    /// </list>
    /// </remarks>
    public PackagingClass Packaging { get; set; }
    /// <summary>
    /// Price in nok.
    /// </summary>
    public double Price { get; set; }
    /// <summary>
    /// Weight in grams.
    /// </summary>
    public double Weight { get; set; }
    /// <summary>
    /// Length in cm.
    /// </summary>
    public double Length { get; set; }
    /// <summary>
    /// Width in cm.
    /// </summary>
    public double Width { get; set; }
    /// <summary>
    /// Height in cm.
    /// </summary>
    public double Height { get; set; }
    /// <summary>
    /// Volume in cm^3.
    /// </summary>
    public double Volume => Length * Width * Height;
    /// <summary>
    /// Density in g/cm^3
    /// </summary>
    public double Density => Weight / Volume;

    public Product(int id, string name, string description, PackagingClass packaging, double price,
        double weight, double length, double width, double height)
    {
        Id = id;
        Name = name;
        Description = description;
        Packaging = packaging;
        Price = price;
        Weight = weight;
        Length = length;
        Width = width;
        Height = height;
    }

    public int CompareTo(Product? other)
    {
        if (other == null) return 1;

        // If same packaging then sort by weight
        if (Packaging == other.Packaging)
        {
            return Weight.CompareTo(other.Weight) * -1;
        }

        // If one has type D and the other does not, order by type
        if (Packaging == PackagingClass.TypeD && other.Packaging != PackagingClass.TypeD)
        {
            return 1;
        }
        else if (Packaging != PackagingClass.TypeD && other.Packaging == PackagingClass.TypeD)
        {
            return -1;
        }

        // If weight difference is too big, sort by weight
        if (Weight / other.Weight <= 0.2 || other.Weight / Weight <= 0.2)
        {
            return Weight.CompareTo(other.Weight) * -1;
        }

        // Sort by packaging
        return Packaging.CompareTo(other.Packaging);
    }
}
