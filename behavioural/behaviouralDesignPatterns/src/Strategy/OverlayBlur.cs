namespace behaviouralDesignPatterns.src.Strategy;

public class OverlayBlur : IOverlay
{
  public void Apply()
  {
    Console.WriteLine("Applying blur overlay");
  }
}
