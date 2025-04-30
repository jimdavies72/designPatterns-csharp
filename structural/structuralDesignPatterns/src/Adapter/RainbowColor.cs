// This is the Adapter class using Composition

using System;
using structuralDesignPatterns.src.Adapter.ColourLibrary;

namespace structuralDesignPatterns.src.Adapter;

public class RainbowColor : IColor
{
  private Rainbow _rainbow;

  public RainbowColor(Rainbow rainbow)
  {
    _rainbow = rainbow;
  }

  public void Apply(Video video)
  {
    _rainbow.Setup();
    _rainbow.Update(video);
  }
}
