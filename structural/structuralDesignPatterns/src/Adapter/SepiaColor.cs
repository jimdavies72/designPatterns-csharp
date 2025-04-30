using System;

namespace structuralDesignPatterns.src.Adapter;

public class SepiaColor : IColor
{
  public void Apply(Video video)
  {
    Console.WriteLine("Applying sepia color to video");
  }
}
