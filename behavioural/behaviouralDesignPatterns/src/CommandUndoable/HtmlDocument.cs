namespace behaviouralDesignPatterns.src.CommandUndoable;

public class HtmlDocument
{
  public string Content = "";

  public void MakeItalic()
  {
    Content = "<i>" + Content + "</i>";
  }
}