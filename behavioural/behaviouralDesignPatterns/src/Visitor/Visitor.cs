namespace behaviouralDesignPatterns.src.Visitor;

public interface Visitor
{
  void VisitRetail(RetailClient retailClient);
  void VisitRestaurant(RestaurantClient restaurantClient);
  void VisitLaw(LawClient lawClient);
}
