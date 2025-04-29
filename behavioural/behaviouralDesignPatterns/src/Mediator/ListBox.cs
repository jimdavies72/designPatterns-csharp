// Concrete Colleague class
namespace behaviouralDesignPatterns.src.Mediator;

public class ListBox : UIControl
{
  private string _selection = string.Empty;

  public ListBox(DialogBox owner) : base(owner) { }

  public string GetSelection()
  {
    return _selection;
  }

  public void SetSelection(string selection)
  {
    _selection = selection;
    _owner.Changed(this);
  }
}