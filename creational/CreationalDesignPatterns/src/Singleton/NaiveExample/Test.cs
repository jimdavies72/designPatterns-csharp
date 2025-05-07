using System;

namespace CreationalDesignPatterns.src.Singleton.NaiveExample;

public class Test
{
  public static void Run()
  {
    var settings = new AppSettings();
    Console.WriteLine(settings.Get("app_name"));
    Console.WriteLine(settings.Get("app_creator"));
  }
}
