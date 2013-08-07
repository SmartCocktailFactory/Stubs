using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebserviceAnalysis {
  public class Drink {
    public string drinkId { get; set; }
    public string drinkName { get; set; }
    public string description { get; set; }
    public string taste { get; set; }
    public string[] ingredients { get; set; }
    public string drinkCategory { get; set; }
    public int rating { get; set; }
  }
}
