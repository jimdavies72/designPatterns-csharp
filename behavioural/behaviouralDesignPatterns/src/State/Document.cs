
namespace behaviouralDesignPatterns.src.State;

public class Document
{
  public IState State { get; set; }
  public UserRoles CurrentUserRole { get; set; }

  public Document(UserRoles currentUserRole)
  {
    State = new DraftState(this);
    CurrentUserRole = currentUserRole;
  }

  public void Publish()
  {
    State.Publish();
  }
}