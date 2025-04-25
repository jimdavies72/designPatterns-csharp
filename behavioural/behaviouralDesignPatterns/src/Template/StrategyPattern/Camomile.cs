namespace behaviouralDesignPatterns.src.Template.StrategyPattern;

public class Camomile : IBeverage
{
  public void Prepare()
  {
    Brew();
  }

  private void Brew()
  {
    Console.WriteLine("Brewing Camomile for 3 mins");
  }
}