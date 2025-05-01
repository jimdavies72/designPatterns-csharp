using System;

namespace structuralDesignPatterns.src.Flyweight.NaiveExample;

public class CropService
{
  public List<Crop> GetCrops()
  {
    List<Crop> cropList = new List<Crop>();

    //fetch from db
    var carrot1 = new Crop(1, 4, CropType.Carrot, new byte[] { 1 });
    var carrot2 = new Crop(1, 5, CropType.Carrot, new byte[] { 1 });
    var carrot3 = new Crop(1, 6, CropType.Carrot, new byte[] { 1 });

    cropList.Add(carrot1);
    cropList.Add(carrot2);
    cropList.Add(carrot3);

    return cropList;

  }
}
