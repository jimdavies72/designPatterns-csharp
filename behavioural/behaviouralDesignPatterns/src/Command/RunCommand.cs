namespace behaviouralDesignPatterns.src.Command;

public class RunCommand
{
  public static void RunCommanPattern()
  {
    var light = new Light();
    var remoteControl = new RemoteControl(new TurnOn(light));
    remoteControl.PressButton();

    remoteControl.SetCommand(new Dim(light));
    remoteControl.PressButton();

    remoteControl.SetCommand(new TurnOff(light));
    remoteControl.PressButton();
  }
}