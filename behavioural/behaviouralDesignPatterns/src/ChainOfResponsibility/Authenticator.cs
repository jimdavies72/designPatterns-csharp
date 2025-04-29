using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility;

public class Authenticator : Handler
{
  public override bool DoHandle(HttpRequest request)
  {
    var username = request.GetUsername();
    var password = request.GetPassword();

    Console.WriteLine("Authenticating");

    //some simple authentication rules
    return !(username == "joe" && password == "pass01"); //return false onto next handler
  }
}
