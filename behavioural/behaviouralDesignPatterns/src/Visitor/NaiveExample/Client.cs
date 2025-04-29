using System;

namespace behaviouralDesignPatterns.src.Visitor.NaiveExample;

public abstract class Client
{
 protected string _name = string.Empty;
 protected string _email = string.Empty;

 public Client(string name, string email)
 {
  _name = name;
  _email = email;
 }

 public abstract void SendEmail();
}
