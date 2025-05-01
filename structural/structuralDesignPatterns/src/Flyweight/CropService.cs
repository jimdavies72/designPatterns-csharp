using System;

namespace structuralDesignPatterns.src.Flyweight;

public class CropService
{
  private CropIconFactory _iconFactory;

  public CropService(CropIconFactory iconFactory)
  {
    _iconFactory = iconFactory;
  }
  
  public List<Crop> GetCrops()
  {
    List<Crop> cropList = new List<Crop>();

    //fetch from db
    var carrot1 = new Crop(1, 4, _iconFactory.GetCropIcon(CropType.Carrot));
    var carrot2 = new Crop(1, 5, _iconFactory.GetCropIcon(CropType.Carrot));
    var carrot3 = new Crop(1, 6, _iconFactory.GetCropIcon(CropType.Carrot));

    cropList.Add(carrot1);
    cropList.Add(carrot2);
    cropList.Add(carrot3);

    return cropList;

  }
}
