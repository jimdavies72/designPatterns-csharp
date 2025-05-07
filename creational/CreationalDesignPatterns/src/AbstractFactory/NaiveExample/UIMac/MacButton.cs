using System;

namespace CreationalDesignPatterns.src.AbstractFactory.NaiveExample.UIMac;

public class MacButton : IButton
{
  public void Render()
  {
    Console.WriteLine("Mac: Render button");
  }
}
