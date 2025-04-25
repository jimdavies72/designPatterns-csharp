namespace behaviouralDesignPatterns.src.Template.TemplateMethod;

public class Camomile : Beverage
{
  protected override void Brew()
  {
    Console.WriteLine("Brewing Camomile for 2 mins");
  }

  
}