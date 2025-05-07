using System;

namespace CreationalDesignPatterns.src.Singleton.NaiveExample;

public class RunSingletonNaiveExample
{
  public static void RunSingletonNaiveExampleCode()
  {
    var settings = new AppSettings();
    settings.Set("app_name", "Design Patterns in C#");
    settings.Set("app_creator", "James");

    Console.WriteLine(settings.Get("app_name"));
    Console.WriteLine(settings.Get("app_creator"));

    // will return null
    Test.Run();
  }
}
