using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel {
    public class Sale {
        private List<DrinkSale> innerDrinks = new List<DrinkSale>();

        public int Id { get; set; }
        public List<DrinkSale> drinks { get { return innerDrinks; } }
        public double revenue { get; set; }
        public DateTime dateTime { get; set; }

        public void addDrink(DrinkSale drink) => innerDrinks.Add(drink);
    }
}
