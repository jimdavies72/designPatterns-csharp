using System;

namespace structuralDesignPatterns.src.Bridge.NaiveExample;

public abstract class RadioAndTVRemote : RemoteControl
{
  public abstract void ControlTV();
  public abstract void ControlRadio();
}
