using System;

namespace CreationalDesignPatterns.src.Prototype.NaiveExample;

public class Rectangle : IShape
{
  public Rectangle()
  {
  }

  public int Width { get; set; } = 10;
  public int Height { get; set; } = 5;

  public void Draw()
  {
    Console.WriteLine("Drawing Rectangle");
  }
}
