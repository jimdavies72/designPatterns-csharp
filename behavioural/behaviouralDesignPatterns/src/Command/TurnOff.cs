namespace behaviouralDesignPatterns.src.Command;

public class TurnOff : ICommand
{
  private Light _light;

  public TurnOff(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.TurnOff();
  }
}
