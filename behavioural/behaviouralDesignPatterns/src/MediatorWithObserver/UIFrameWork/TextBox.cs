using System;

namespace behaviouralDesignPatterns.src.MediatorWithObserver.UIFrameWork;

public class TextBox : UIControl
{
  private string _text = string.Empty;

  public string GetText()
  {
    return _text;
  }

  public void SetText(string text)
  {
    _text = text;

    NotifyEventHandlers();
  }
}
