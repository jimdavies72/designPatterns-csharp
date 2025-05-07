using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public class WindowsCheckbox : ICheckbox
{
  public void Render()
  {
    Console.WriteLine("Windows: Render checkbox");
  }
}
