using System;

namespace CreationalDesignPatterns.src.Factory.MVCFramework;

public class TwigController : Controller
{
  protected override IViewEngine CreateViewEngine()
  {
    return new TwigViewEngine();
  }
}
