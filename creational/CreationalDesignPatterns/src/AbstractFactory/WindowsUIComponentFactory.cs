using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public class WindowsUIComponentFactory : IUIComponentFactory
{
  public IButton CreateButton()
  {
    return new WindowsButton();
  }

  public ICheckbox CreateCheckbox()
  {
    return new WindowsCheckbox();
  }
}
