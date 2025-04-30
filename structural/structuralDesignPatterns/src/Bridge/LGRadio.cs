using System;

namespace structuralDesignPatterns.src.Bridge;

public class LGRadio : IDevice
{
  public void SetChannel(int channel)
  {
    Console.WriteLine("Setting LG Channel to {0}", channel);
  }

  public void TurnOff()
  {
    Console.WriteLine("Turning LG Radio Off");
  }

  public void TurnOn()
  {
    Console.WriteLine("Turning LG Radio On");
  }

}
