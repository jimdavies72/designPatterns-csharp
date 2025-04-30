// Adapter using inheritance
using System;
using structuralDesignPatterns.src.Adapter.ColourLibrary;

namespace structuralDesignPatterns.src.Adapter;

public class RainbowAdapter : Rainbow, IColor
{
  public void Apply(Video video)
  {
    Setup();
    Update(video);
  }
}
