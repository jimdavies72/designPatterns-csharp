using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public class WindowsButton : IButton
{
  public void Render()
  {
    Console.WriteLine("Windows: Render button");
  }
}
