using System;

namespace CreationalDesignPatterns.src.AbstractFactory.NaiveExample.UIWindows;

public class WindowsCheckbox : ICheckbox
{
  public void Render()
  {
    Console.WriteLine("Windows: Render checkbox");
  }
}
