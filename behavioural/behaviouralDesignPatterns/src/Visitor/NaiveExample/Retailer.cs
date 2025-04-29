using System;

namespace behaviouralDesignPatterns.src.Visitor.NaiveExample;

public class RetailClient : Client
{
  public RetailClient(string name, string email) : base(name, email)
  {
  }

  public override void SendEmail()
  {
    Console.WriteLine("Sending Specialised Retailer Selling Tips {0}", _email);
  }
}
