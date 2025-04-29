using System;

namespace behaviouralDesignPatterns.src.Visitor.NaiveExample;

public class LawClient : Client
{
  public LawClient(string name, string email) : base(name, email)
  {
    
  }

  public override void SendEmail()
  {
    Console.WriteLine("Sending Specialised Law Marketing Tips {0}", _email);
  }
}
