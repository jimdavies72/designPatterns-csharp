using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility.NaiveExample;

public class Logger
{
  public void Log(HttpRequest request)
  {
    Console.WriteLine("Log");
  }
}
