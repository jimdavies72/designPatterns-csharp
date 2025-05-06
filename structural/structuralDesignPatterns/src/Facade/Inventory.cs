using System;
using System.Drawing;

namespace structuralDesignPatterns.src.Facade;

public class Inventory
{
  public bool CheckInventory(string itemId)
  {
    return true; //always return true for the simple example..
  }

  public void ReduceInventory(string itemId, int amount )
  {
    Console.WriteLine("Reducing Inventory of {0} by {1}", itemId, amount);  
  }
}
