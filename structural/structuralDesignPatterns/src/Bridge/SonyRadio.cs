using System;

namespace structuralDesignPatterns.src.Bridge;

public class SonyRadio : IDevice
{
  public void SetChannel(int channel)
  {
    Console.WriteLine("Setting Sony Channel to {0}", channel);
  }

  public void TurnOff()
  {
    Console.WriteLine("Turning Sony Radio Off");
  }

  public void TurnOn()
  {
    Console.WriteLine("Turning Sony Radio On");
  }
}
