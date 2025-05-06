namespace structuralDesignPatterns.src.Facade;

public class RunFacade
{
  public static void RunFacadePattern()
  {
    // All of this code can now be removed as it is implemented in the OrderService class
    // var orderRequest = new OrderRequest();
    // var auth = new Authenticate();
    // var inventory = new Inventory();
    // foreach (var id in orderRequest.ItemIds)
    // {
    //   inventory.CheckInventory(id);
    // }
    // var payment = new Payment(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
    // payment.Pay();
    // var orderFulfillment = new OrderFulfillment(inventory);
    // orderFulfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemIds);


    // incoming user order request containing all their data...
    var orderRequest = new OrderRequest();
    var orderService = new OrderService();
    orderService.Order(orderRequest);
  }
}
