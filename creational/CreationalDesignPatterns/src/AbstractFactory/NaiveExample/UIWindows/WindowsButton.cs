using System;

namespace CreationalDesignPatterns.src.AbstractFactory.NaiveExample.UIWindows;

public class WindowsButton : IButton
{
  public void Render()
  {
    Console.WriteLine("Windows: Render button");
  }
}
