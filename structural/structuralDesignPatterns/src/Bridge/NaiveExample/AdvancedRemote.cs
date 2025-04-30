using System;

namespace structuralDesignPatterns.src.Bridge.NaiveExample;

public abstract class AdvancedRemote : RemoteControl
{
  public abstract void SetChannel(int channel);
}

