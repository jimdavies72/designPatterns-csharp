using System;

namespace CreationalDesignPatterns.src.Prototype;

public class ShapeActions
{
  public IShape Duplicate(IShape shape)
  {
    Console.WriteLine("Duplicating shape");
    return shape.Duplicate();
  }
}
