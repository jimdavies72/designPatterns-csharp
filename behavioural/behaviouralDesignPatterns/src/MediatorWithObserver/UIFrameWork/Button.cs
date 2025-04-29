namespace behaviouralDesignPatterns.src.MediatorWithObserver.UIFrameWork;

public class Button : UIControl
{
  private bool _isEnabled;

  public bool isEnabled()
  {
    return _isEnabled;
  }

  public void SetEnabled(bool isEnabled)
  {
    _isEnabled = isEnabled;
    NotifyEventHandlers();
  }
}
