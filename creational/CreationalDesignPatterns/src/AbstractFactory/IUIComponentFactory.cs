using System;

namespace CreationalDesignPatterns.src.AbstractFactory;

public interface IUIComponentFactory
{
IButton CreateButton();
ICheckbox CreateCheckbox();
}
