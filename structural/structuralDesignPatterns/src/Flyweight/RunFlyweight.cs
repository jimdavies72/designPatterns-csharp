using System;

namespace structuralDesignPatterns.src.Flyweight;

public class RunFlyweight
{
public static void RunFlyWeightPattern()
{

  var cropService = new CropService(new CropIconFactory());
  var crops = cropService.GetCrops();
  foreach(var crop in crops)
  {
    crop.Render();
  }
}
}
