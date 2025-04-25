namespace behaviouralDesignPatterns.src.Command;

// The Receiver Class
public class Light 
{
  public void TurnOn()
  {
    Console.WriteLine("Light turned on");
  }

  public void TurnOff()
  {
    Console.WriteLine("Light turned off");
  }

  public void Dim()
  {
    Console.WriteLine("Light dimmed");
  }
}