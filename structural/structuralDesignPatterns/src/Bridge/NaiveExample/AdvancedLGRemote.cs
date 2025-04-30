using System;

namespace structuralDesignPatterns.src.Bridge.NaiveExample;

public class AdvancedLGRemote : AdvancedRemote
{
  public override void SetChannel(int channel)
  {
    Console.WriteLine("Setting LG Channel to {0}", channel);
  }

  public override void TurnOff()
  {
    Console.WriteLine("Turning LG Radio Off");
  }

  public override void TurnOn()
  {
    Console.WriteLine("Turning LG Radio On");
  }

  public override void VolumeDown()
  {
    Console.WriteLine("Turning LG Radio Volume Down");
  }

  public override void VolumeUp()
  {
    Console.WriteLine("Turning LG Radio Volume Up");
  }
}
