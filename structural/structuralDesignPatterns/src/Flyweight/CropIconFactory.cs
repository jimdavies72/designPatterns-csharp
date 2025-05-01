//Factory class

using System;

namespace structuralDesignPatterns.src.Flyweight;

public class CropIconFactory
{
  // this is the cache
  private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();

  public CropIcon GetCropIcon(CropType cropType)
  {
    if (!_icons.ContainsKey(cropType))
    {
      var icon = new CropIcon(cropType, new byte[1]);
      _icons.Add(cropType, icon);
    }

    return _icons[cropType];
  }
}
