using System;

namespace structuralDesignPatterns.src.Composite;

public class Keyboard : IItem
{
  private float _price = 40.00f;

  public float GetPrice()
  {
    return _price;
  }
}
