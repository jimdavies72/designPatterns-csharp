using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility.NaiveExample;

public class Validator
{
  public void Validate(HttpRequest request)
  {
    var username = request.GetUsername();
    var password = request.GetPassword();

    // some simple validation rules - Trim whitespace
    request.ValidateUsername = username.Trim();
    request.ValidatePassword = password.Trim();
  }
}
