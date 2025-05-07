using System;

namespace CreationalDesignPatterns.src.Singleton;

public class RunSingleton
{
  public static void RunSingletonPattern()
  {
    // we cannot create a new instance as the AppSettings constructor is private.
    // we call the AppSetting.GetInstance() method instead
    var settings = AppSettings.GetInstance();
    settings.Set("app_name", "Design Patterns in C#");
    settings.Set("app_creator", "James");

    Console.WriteLine(settings.Get("app_name"));
    Console.WriteLine(settings.Get("app_creator"));

    // will return the same instance
    Test.Run();
  }
}
