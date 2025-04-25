namespace behaviouralDesignPatterns.src.Command;

public class TurnOn : ICommand
{
  private Light _light;

  public TurnOn(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.TurnOn();
  }
}
