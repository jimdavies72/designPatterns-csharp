// Context class

using System;
using System.Security.Cryptography;

namespace structuralDesignPatterns.src.Flyweight;

public class Crop
{
  //extrinsic state
  private int _x; // 4 bytes
  private int _y; //4 bytes

  private CropIcon _cropIcon;

  public Crop(int x, int y, CropIcon cropIcon)
  {
    _x = x;
    _y = y;
    _cropIcon = cropIcon;
  }

  public void Render()
  {
    Console.WriteLine($"Rendering crop {_cropIcon.GetType()} at {_x}, {_y}");
  }
}
