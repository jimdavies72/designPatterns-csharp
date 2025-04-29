using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility;

public class Logger : Handler
{
  public override bool DoHandle(HttpRequest request)
  {
    Console.WriteLine("Logged");
    return false;
  }
}
