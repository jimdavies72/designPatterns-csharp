using System;

namespace CreationalDesignPatterns.src.Prototype;

public class Rectangle : IShape
{
  public int Width { get; set; } = 10;
  public int Height { get; set; } = 5;

  public void Draw()
  {
    Console.WriteLine("Drawing Rectangle");
  }

  public IShape Duplicate()
  {
    var newRectangle = new Rectangle();
    newRectangle.Width = Width;
    newRectangle.Height = Height;
    return newRectangle;
  }
}
