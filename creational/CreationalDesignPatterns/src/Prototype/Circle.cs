using System;

namespace CreationalDesignPatterns.src.Prototype;

public class Circle : IShape
{
  public int Radius { get; set; } = 5;

  public void Draw()
  {
    Console.WriteLine("Drawing Circle");
  }

  public IShape Duplicate()
  {
    var newCircle = new Circle(); // the clone
    newCircle.Radius = Radius;
    return newCircle;
  }
}
