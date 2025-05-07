using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public class MacCheckbox : ICheckbox
{
  public void Render()
  {
    Console.WriteLine("Mac: Render checkbox");
  }
}
