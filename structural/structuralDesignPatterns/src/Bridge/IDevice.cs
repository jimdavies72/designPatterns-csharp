using System;

namespace structuralDesignPatterns.src.Bridge;

public interface IDevice
{
  void TurnOn();
  void TurnOff();
  void SetChannel(int channel);
}
