namespace behaviouralDesignPatterns.src.Template.StrategyPattern;

public class BeverageMaker
{
  private IBeverage _beverage;

  public BeverageMaker(IBeverage beverage)
  {
    _beverage = beverage;
  }

  public void SetBeverage(IBeverage beverage)
  {
    _beverage = beverage;
  }

  public void MakeBeverage()
  {
    // common beverage operations
    BoilWater();
    PourWaterIntoCup();

    // specific beverage operations
    _beverage.Prepare();
  }

  private void BoilWater()
  {
    Console.WriteLine("Boiling water");
  }

  private void PourWaterIntoCup()
  {
    Console.WriteLine("Pouring water into cup");
  }
}