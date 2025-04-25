// Solving problem using Polymorphism and the Strategy Pattern

namespace behaviouralDesignPatterns.src.Template.StrategyPattern;

public class RunTemplateStrategy
{
  public static void RunTemplateStrategyPattern()
  {
    var beverageMaker = new BeverageMaker(new Coffee());
    beverageMaker.MakeBeverage();

  }
}