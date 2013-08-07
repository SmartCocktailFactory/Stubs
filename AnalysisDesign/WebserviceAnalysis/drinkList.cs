using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebserviceAnalysis {

  public class DrinkListContent {
    public string drinkId { get; set; }
    public string drinkName { get; set; }
  }

  public class drinkList {
    public List<DrinkListContent> drinks { get; set; }
  }
}
