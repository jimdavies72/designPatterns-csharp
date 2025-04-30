using System;

namespace structuralDesignPatterns.src.Composite;

public class Microphone : IItem
{
  private float _price = 35.00f;

  public float GetPrice()
  {
   return _price;
  }
}
