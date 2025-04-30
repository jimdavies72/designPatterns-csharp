using System;

namespace structuralDesignPatterns.src.Adapter;

public class BlackAndWhiteColor : IColor
{
  public void Apply(Video video)
  {
    //some code that would apply a black and white overlay here...
    Console.WriteLine("Applying black and white color to video");
  }
}
