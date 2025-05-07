using System;

namespace CreationalDesignPatterns.src.AbstractFactory.NaiveExample;

public class RunAbstractFactoryNaiveExample
{
  public static void RunAbstractFactoryNaiveExampleCode()
  {
    var os = OperatingSystemType.Mac;
    var userSetttingsForm = new UserSetttingsForm();
    userSetttingsForm.Render(os);
  }
}
