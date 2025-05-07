using CreationalDesignPatterns.src.AbstractFactory.NaiveExample.UIMac;
using CreationalDesignPatterns.src.AbstractFactory.NaiveExample.UIWindows;

namespace CreationalDesignPatterns.src.AbstractFactory.NaiveExample;

public class UserSetttingsForm
{
  public void Render(OperatingSystemType os)
  {
    if (os == OperatingSystemType.Windows)
    {
      new WindowsButton().Render();
      new WindowsCheckbox().Render();
    } else if (os == OperatingSystemType.Mac)
    {
      new MacButton().Render();
      new MacCheckbox().Render();
    }
  }
}
