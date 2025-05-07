using System;

namespace CreationalDesignPatterns.src.Factory.MVCFramework;

public class BladeViewEngine : IViewEngine
{
  public string Render(string fileName, Dictionary<string, object> data)
  {
    return $"view rendered from {fileName} by Blade";
  }
}
