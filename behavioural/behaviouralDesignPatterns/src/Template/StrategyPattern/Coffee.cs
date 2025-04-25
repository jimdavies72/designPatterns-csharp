namespace behaviouralDesignPatterns.src.Template.StrategyPattern;

public class Coffee : IBeverage
{
  public void Prepare()
  {
    Brew();
    AddCondiments();
  }

  private void Brew()
  {
    Console.WriteLine("Brewing Coffee for 4 mins");
  }

  private void AddCondiments()
  {
    if (CustomerWantsCondiments())
    {
      Console.WriteLine("Adding Cream");
    }
  }

  private bool CustomerWantsCondiments()
  {
    Console.WriteLine("Would you like Cream in your Coffee? (y/n) ");
    string? input = Console.ReadLine();
    return string.Equals(input, "y", StringComparison.OrdinalIgnoreCase);

  }
}