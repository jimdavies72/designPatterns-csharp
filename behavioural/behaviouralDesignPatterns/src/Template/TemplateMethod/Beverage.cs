namespace behaviouralDesignPatterns.src.Template.TemplateMethod;

public abstract class Beverage()
{

  // Template method
  public void Prepare()
  {
    BoilWater();
    PourWaterIntoCup();

    Brew();
    AddCondiments();
  }

  private void BoilWater()
  {
    Console.WriteLine("T Boiling water");
  }

  private void PourWaterIntoCup()
  {
    Console.WriteLine("T Pouring water into cup");
  }

  protected abstract void Brew();

  protected virtual void AddCondiments() { }

}