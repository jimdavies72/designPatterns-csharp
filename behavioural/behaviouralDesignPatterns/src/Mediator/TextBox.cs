// Concrete Colleague class
namespace behaviouralDesignPatterns.src.Mediator;

// Inherits from UIControl class
public class TextBox : UIControl
{
  private string _text = string.Empty;

  public TextBox(DialogBox owner) : base(owner)
  {
  }

  public string GetText()
  {
    return _text;
  }

  public void SetText(string text)
  {
    _text = text;

    // alert the mediator that this UI control has changed
    _owner.Changed(this);
  }
}