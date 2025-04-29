using System;

namespace behaviouralDesignPatterns.src.Visitor;

public class PDFExportVisitor : Visitor
{
  public void VisitLaw(LawClient lawClient)
  {
    Console.WriteLine("Exporting Law {0} as PDF", lawClient.GetEmail());
  }

  public void VisitRestaurant(RestaurantClient restaurantClient)
  {
    Console.WriteLine("Exporting Restaurant {0} As PDF", restaurantClient.GetEmail());
  }

  public void VisitRetail(RetailClient retailClient)
  {
    Console.WriteLine("Exporting Retailer {0} As PDF", retailClient.GetEmail());
  }
}
