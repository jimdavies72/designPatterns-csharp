using System;
using CreationalDesignPatterns.src.Factory.MVCFramework;

namespace CreationalDesignPatterns.src.Factory;

public class OrdersController : TwigController
{
  public void ListOrders()
  {
    // simulate fetching users orders from db
    var orders = new Dictionary<string, object>{
      {"Red Socks", "£12.50"},
      {"Tee-Shirt", "£32.99"},
      {"Jeans", "£50.00"}
    };

    Render("orders.blade.php", orders);
  }

  public void GetOrder()
  {
    // simulate getting a single order by id from db
    var order = new Dictionary<string, object>{
      {"Red Socks", "£12.50"},
    };

    Render("order.blade.php", order);
  }
}


