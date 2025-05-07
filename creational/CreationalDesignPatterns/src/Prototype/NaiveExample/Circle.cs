using System;

namespace CreationalDesignPatterns.src.Prototype.NaiveExample;

public class Circle : IShape
{
  public int Radius { get; set; } = 5;

  public void Draw()
  {
    Console.WriteLine("Drawing Circle");
  }
}
