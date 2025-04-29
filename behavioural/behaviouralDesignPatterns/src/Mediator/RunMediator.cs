namespace behaviouralDesignPatterns.src.Mediator;

public class RunMediator
{
  public static void RunMediatorPattern()
  {
    var postsDialogBox = new PostsDialogBox();
    postsDialogBox.SimulateUserInteraction();
  }
}
