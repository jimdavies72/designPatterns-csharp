using System;

//namespace behaviouralDesignPatterns.src.Visitor.NaiveExample;
namespace behaviouralDesignPatterns.src.Visitor;

public class RunVisitor
{
public static void RunVisitorPattern()
{
  //simulate getting client list from db
  var clients = new List<Client>
  {
    new RetailClient("Debenhams", "info@debenhams.co.uk"),
    new RestaurantClient("Dancing Zorba", "team@dancingzorba.co.uk"),
    new LawClient("Quack, Giraffe and Spank Law Firm", "legal@thelaw.co.uk")
  };

  foreach (var client in clients)
  {
    //client.Accept(new EmailVisitor());
    client.Accept(new PDFExportVisitor());
  }
}
}
