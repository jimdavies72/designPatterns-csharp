namespace behaviouralDesignPatterns.src.Command;

public class Dim : ICommand
{
  private Light _light;

  public Dim(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.Dim();
  }
}
