using System;

namespace structuralDesignPatterns.src.Adapter.ColourLibrary;

public class Rainbow
{
  // represents the setup config of the Rainbow library...
  public void Setup()
  {
    Console.WriteLine("Setting up Rainbow Filter...");
  }

  // this method represent the 3rd party version of Apply()
  public void Update(Video video)
  {
    Console.WriteLine("Applying Rainbow Filter to video...");
  }
}
