using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility;

public class Validator : Handler
{
  public override bool DoHandle(HttpRequest request)
  {
    var username = request.GetUsername();
    var password = request.GetPassword();

    Console.WriteLine("Validating");

    // some simple validation rules - Trim whitespace
    request.ValidateUsername = username.Trim();
    request.ValidatePassword = password.Trim();

    return request.ValidateUsername == "" || request.ValidatePassword == "";
  }
}
