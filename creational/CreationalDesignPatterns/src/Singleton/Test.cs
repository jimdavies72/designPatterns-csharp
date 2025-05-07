using System;

namespace CreationalDesignPatterns.src.Singleton;

public class Test
{
  public static void Run()
  {
    var settings = AppSettings.GetInstance();
    Console.WriteLine(settings.Get("app_name"));
    Console.WriteLine(settings.Get("app_creator"));
  }

}
