using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public class MacButton : IButton
{
  public void Render()
  {
    Console.WriteLine("Mac: Render button");
  }
}
