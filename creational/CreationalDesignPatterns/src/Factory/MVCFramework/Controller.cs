using System;

namespace CreationalDesignPatterns.src.Factory.MVCFramework;

public class Controller
{
  public void Render(string fileName, Dictionary<string, object> data)
  {

    var viewEngine = CreateViewEngine();
    var html = viewEngine.Render(fileName, data);
    Console.WriteLine(html);
  }

  // acting as the Factory method.
  // this could also be implemented as an abstract method to force the developer create the view engine
  protected virtual IViewEngine CreateViewEngine()
  {
    // default view engine.....
    return new BladeViewEngine();
  }
}
