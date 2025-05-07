using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public class MacUIComponentFactory : IUIComponentFactory
{
  public IButton CreateButton()
  {
    return new MacButton();
  }

  public ICheckbox CreateCheckbox()
  {
    return new MacCheckbox();
  }
}
