using System;

namespace structuralDesignPatterns.src.Composite;

public class Box : IItem
{
  private List<IItem> _items = new List<IItem>();

  public void Add(IItem item)
  {
    _items.Add(item);
  }

  public float GetPrice()
  {
    float total = 0;

    foreach (var item in _items)
    {
      total += item.GetPrice();
    }

    return total;
  }
}
