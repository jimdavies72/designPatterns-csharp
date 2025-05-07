namespace CreationalDesignPatterns.src.AbstractFactory;

public class RunAbstractFactory
{
  public static void RunAbstractFactoryPattern()
  {
    var os = OperatingSystemType.Mac;
    IUIComponentFactory uIComponentFactory;

    if (os == OperatingSystemType.Windows)
    {
      uIComponentFactory = new WindowsUIComponentFactory();
    }
    else if (os == OperatingSystemType.Mac)
    {
      uIComponentFactory = new MacUIComponentFactory();
    }
    else
    {
      throw new Exception("unsupported OS");
    }

    new UserSetttingsForm().Render(uIComponentFactory);

  }
}
