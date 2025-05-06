// Facade class

namespace structuralDesignPatterns.src.Facade;

public class OrderService
{
public void Order (OrderRequest orderRequest)
{
    orderRequest = new OrderRequest();
    var auth = new Authenticate();
    var inventory = new Inventory();
    foreach (var id in orderRequest.ItemIds)
    {
      inventory.CheckInventory(id);
    }
    var payment = new Payment(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
    payment.Pay();
    var orderFulfillment = new OrderFulfillment(inventory);
    orderFulfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemIds);
  }
}
