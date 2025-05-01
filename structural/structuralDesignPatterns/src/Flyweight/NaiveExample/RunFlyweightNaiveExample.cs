using System;

namespace structuralDesignPatterns.src.Flyweight.NaiveExample;

public class RunFlyweightNaiveExample
{
  public static void RunFlyWeightNaiveExampleCode()
  {
    var cropService = new CropService();
    foreach (var crop in cropService.GetCrops())
    {
      crop.Render();
    }
  }
}
