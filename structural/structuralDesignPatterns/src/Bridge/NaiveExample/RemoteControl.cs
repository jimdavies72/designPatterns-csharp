using System;

namespace structuralDesignPatterns.src.Bridge.NaiveExample;

public abstract class RemoteControl
{
public abstract void TurnOn();
public abstract void TurnOff();
public abstract void VolumeUp();
public abstract void VolumeDown();
}
