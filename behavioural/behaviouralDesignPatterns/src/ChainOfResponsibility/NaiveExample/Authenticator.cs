using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility.NaiveExample;

public class Authenticator
{
  public bool Authenticate(HttpRequest request)
  {
    var username  = request.GetUsername();
    var password = request.GetPassword();
    
    //some simple authentication rules
    return username == "joe" && password == "pass01";
    
  }
}
