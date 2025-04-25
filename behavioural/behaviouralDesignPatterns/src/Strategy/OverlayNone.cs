namespace behaviouralDesignPatterns.src.Strategy;

public class OverlayNone : IOverlay
{
  public void Apply()
  {
    Console.WriteLine("Applying no overlay");
  }
}