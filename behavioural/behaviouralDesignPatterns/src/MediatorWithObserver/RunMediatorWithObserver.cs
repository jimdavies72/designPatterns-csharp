namespace behaviouralDesignPatterns.src.MediatorWithObserver;

public class RunMediatorWithObserver
{
  public static void RunMediatorWithObserverPattern()
  {
    var postsDialogBox = new PostsDialogBox();
    postsDialogBox.SimulateUserInteraction();
  }
  
}