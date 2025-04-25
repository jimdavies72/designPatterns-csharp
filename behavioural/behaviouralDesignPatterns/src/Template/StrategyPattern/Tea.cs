namespace behaviouralDesignPatterns.src.Template.StrategyPattern;

public class Tea : IBeverage
{
  public void Prepare()
  {
    Brew();
    AddCondiments();
  }

  private void Brew()
  {
    Console.WriteLine("Brewing tea for 3 mins");
  }

  private void AddCondiments()
  {
    if (CustomerWantsCondiments())
    {
      Console.WriteLine("Adding lemon");
    }
  }

  private bool CustomerWantsCondiments()
  {
    Console.WriteLine("Would you like lemon with your Tea? (y/n) ");
    string? input = Console.ReadLine();
    return string.Equals(input, "y", StringComparison.OrdinalIgnoreCase);
  }
}