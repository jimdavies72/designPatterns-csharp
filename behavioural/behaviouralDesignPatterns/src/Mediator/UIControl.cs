// Colleague Class. Usually an Abstract Class (Go4) however, this example is not abstract
namespace behaviouralDesignPatterns.src.Mediator;

public class UIControl
{
  protected DialogBox _owner;

  public UIControl(DialogBox owner)
  {
    _owner = owner;
  }

}