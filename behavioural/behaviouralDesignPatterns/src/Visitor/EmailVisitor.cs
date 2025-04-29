using System;

namespace behaviouralDesignPatterns.src.Visitor;

public class EmailVisitor : Visitor
{
  public void VisitLaw(LawClient lawClient)
  {
    Console.WriteLine("Sending Specialised Law Marketing Tips {0}", lawClient.GetEmail());
  }

  public void VisitRestaurant(RestaurantClient restaurantClient)
  {
    Console.WriteLine("Sending Specialised Restaurant Food Tips {0}", restaurantClient.GetEmail());
  }

  public void VisitRetail(RetailClient retailClient)
  {
    Console.WriteLine("Sending Specialised Retailer Selling Tips {0}", retailClient.GetEmail());
  }
}
