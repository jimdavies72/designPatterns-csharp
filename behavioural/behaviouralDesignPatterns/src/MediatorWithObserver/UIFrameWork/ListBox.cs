//Concrete control
namespace behaviouralDesignPatterns.src.MediatorWithObserver.UIFrameWork;

public class ListBox : UIControl
{
  private string _selection = string.Empty;

  public string GetSelection()
  {
    return _selection;
  }

  public void SetSelection(string selection)
  {
    _selection = selection;
    NotifyEventHandlers();
  }
}


