using System;

namespace structuralDesignPatterns.src.Bridge;

public class AdvancedRemoteControl : RemoteControl
{
  public AdvancedRemoteControl(IDevice device) : base(device)
  {
  }

  public void SetChannel(int channel)
  {
    Console.WriteLine("Setting Advanced Channel to {0}", channel);
  }
}
