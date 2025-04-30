using System;

namespace structuralDesignPatterns.src.Bridge;

public class RunBridge
{
  public static void RunBridgePattern()
  {
    var lgRemoteControl = new RemoteControl(new LGRadio());
    lgRemoteControl.TurnOn();
    lgRemoteControl.TurnOff();

    var advancedSonyRemoteControl = new AdvancedRemoteControl(new SonyRadio());
    advancedSonyRemoteControl.TurnOn();
    advancedSonyRemoteControl.TurnOff();
    advancedSonyRemoteControl.SetChannel(5);
  }
}
