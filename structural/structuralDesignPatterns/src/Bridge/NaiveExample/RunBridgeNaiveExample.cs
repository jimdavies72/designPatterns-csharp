using System;

namespace structuralDesignPatterns.src.Bridge.NaiveExample;

public class RunBridgeNaiveExample
{
  public static void RunBridgeNaiveExampleCode()
  {
    var lgRemote = new LGRemote();
    lgRemote.TurnOn();
    lgRemote.TurnOff();

    var lgRadioAndTVRemote = new LGRadioAndTVRemote();
    lgRadioAndTVRemote.ControlTV();
    lgRadioAndTVRemote.ControlRadio();
  }
}
