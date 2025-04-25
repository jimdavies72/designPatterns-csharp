namespace behaviouralDesignPatterns.src.Template.TemplateMethod;

public class Tea : Beverage // implement the abstract class: Beverage
{
  protected override void Brew()
  {
    Console.WriteLine("T Brewing tea for 3 mins");
  }

  protected override void AddCondiments()
  {
    if (CustomerWantsCondiments())
    {
      Console.WriteLine("T Adding lemon");
    }
  }

  private bool CustomerWantsCondiments()
  {
    Console.WriteLine("T Would you like lemon with your Tea? (y/n) ");
    string? input = Console.ReadLine();
    return string.Equals(input, "y", StringComparison.OrdinalIgnoreCase);
  }
}