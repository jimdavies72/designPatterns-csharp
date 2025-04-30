using System;

namespace structuralDesignPatterns.src.Bridge.NaiveExample;

public class LGRadioAndTVRemote : RadioAndTVRemote
{
  public override void ControlRadio()
  {
    Console.WriteLine("Controlling LG Radio");
  }

  public override void ControlTV()
  {
    Console.WriteLine("Controlling LG TV"); 
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
