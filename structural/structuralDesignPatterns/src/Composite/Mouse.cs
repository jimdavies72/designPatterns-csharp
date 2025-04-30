using System;

namespace structuralDesignPatterns.src.Composite;

public class Mouse : IItem
{
  private float _price = 15.00f;

  public float GetPrice()
  {
    return _price;
  }
}
