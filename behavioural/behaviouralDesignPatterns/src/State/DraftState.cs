
namespace behaviouralDesignPatterns.src.State;

public class DraftState : IState
{
  private Document _document;

  public DraftState(Document document)
  {
    _document = document;
  }

  public void Publish()
  {
    _document.State = new ModerationState(_document);
  }
}