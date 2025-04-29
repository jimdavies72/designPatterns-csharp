using System;

namespace behaviouralDesignPatterns.src.Visitor;

public class RestaurantClient : Client
{
  public RestaurantClient(string name, string email) : base(name, email)
  {
  }

  public override void Accept(Visitor visitor)
  {
    visitor.VisitRestaurant(this);
  }
}
