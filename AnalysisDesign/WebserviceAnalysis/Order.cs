using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebserviceAnalysis {
  public class OrderList {
    public List<Order> Orders { get; set; }
  }

  public class Order {
    public string orderId { get; set; }
    public string orderOwner { get; set; }
    public int estimatedTimeSec { get; set; }
    public string drinkId { get; set; }
  }
}
