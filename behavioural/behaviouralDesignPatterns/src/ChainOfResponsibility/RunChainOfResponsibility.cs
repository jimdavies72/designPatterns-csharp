using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility;

public class RunChainOfResponsibility
{
  public static void RunChainOfResponsibilityPattern()
  {
    var validator = new Validator();
    var authenticator = new Authenticator();
    var logger = new Logger();

    validator.SetNext(authenticator).SetNext(logger);

    var server = new WebServer(validator);
    var request = new HttpRequest("", "pass01");

    server.Handle(request);


    //Naive Example
    // var server = new WebServer();
    // var request = new HttpRequest("Joe", "pass01");
    // server.Handle(request);
  }
}
