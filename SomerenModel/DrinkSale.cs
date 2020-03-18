using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel {
    public class DrinkSale: Drink {
        public int quantity { get; set; }
        public double revenue { get; set; }
        public double totalRevenue { get { return quantity * revenue; } }
    }
}
