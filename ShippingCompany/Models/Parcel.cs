using System.Collections.Generic;

namespace ShippingCompany.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(double length, double width, double height, double weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;

      _instances.Add(this);
    }

    public double Volume()
    {
      return (Length * Width * Height);
    }

    public double CostToShip()
    {
      double costPerCubicInch = 10;
      return Volume() * costPerCubicInch;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}