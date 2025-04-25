namespace behaviouralDesignPatterns.src.CommandUndoable;

public class ItalicCommand : IUndoableCommand
{
  private HtmlDocument _doc;
  private string _prevContent = "";
  private History _history;

  public ItalicCommand(HtmlDocument doc, History history)
  {
    _doc = doc;
    _history = history;
  }

  public void Execute()
  {
    _prevContent = _doc.Content;
    _doc.MakeItalic();
    _history.Push(this);
  }

  public void Unexectute()
  {
    _doc.Content = _prevContent;
  }
}