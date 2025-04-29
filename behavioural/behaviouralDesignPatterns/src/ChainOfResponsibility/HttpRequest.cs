using System;

namespace behaviouralDesignPatterns.src.ChainOfResponsibility;

public class HttpRequest
{
  private string _username = string.Empty;
  private string _password = string.Empty;
  public string ValidateUsername { get; set; }
  public string ValidatePassword { get; set; }

  public HttpRequest(string username, string password)
  {
    _username = username;
    _password = password;
    ValidateUsername = string.Empty;
    ValidatePassword = string.Empty;
  }

  public string GetUsername()
  {
    return _username;
  }

  public string GetPassword()
  {
    return _password;
  }
}
