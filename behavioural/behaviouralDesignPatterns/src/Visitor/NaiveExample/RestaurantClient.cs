using System;

namespace behaviouralDesignPatterns.src.Visitor.NaiveExample;

public class RestaurantClient : Client
{
  public RestaurantClient(string name, string email) : base(name, email)
  {
  }

  public override void SendEmail()
  {
    Console.WriteLine("Sending Specialised Restaurant Food Tips {0}", _email);
  }
}
