using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    private int Length { get; set; }
    private int Width { get; set; }
    private int Height { get; set; }
    private int Weight { get; set; }
    private int CostToShip { get; set; }

    private static List<Parcel> _packages = new List<Parcel> {};

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      CostToShip = 5;
      _packages.Add(this);
    }

    public int GetLength()
    {
      return this.Length;
    }
    public int GetWidth()
    {
      return this.Width;
    }
    public int GetHeight()
    {
      return this.Height;
    }
    public int GetWeight()
    {
      return this.Weight;
    }

    public void SetLength(int length)
    {
      this.Length = length;
    }
    public void SetWidth(int width)
    {
      this.Width = width;
    }
    public void SetHeight(int height)
    {
      this.Height = height;
    }
    public void SetWeight(int weight)
    {
      this.Weight = weight;
    }
    public int Volume()
    {
      return this.Length * this.Width * this.Height;
    }

    public int CalcShip()
    {
      if (((this.Volume() * this.Weight) / 300) < 5)
      {
        return this.CostToShip;
      }
      else
      {
      return ((this.Volume() * this.Weight) / 300);
      }
    }
    public static List<Parcel> GetAll()
    {
      return _packages;
    }

    public static void ClearAll()
    {
      _packages.Clear();
    }
  }
}