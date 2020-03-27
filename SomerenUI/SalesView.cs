using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;

namespace SomerenUI {
    public partial class SalesView:UserControl {
        public SalesView() {
            InitializeComponent();
        }

        private void viewSalesBtn_Click(object sender, EventArgs e) {
            // Get date times from input calendars
            DateTime startDateTime = startDateCalendar.SelectionStart;
            DateTime endDateTime = endDateCalendar.SelectionStart;

            Sales_Services sales_Services = new Sales_Services();

            List<Sale> sales = sales_Services.getSalesByDateRange(startDateTime, endDateTime);

            salesList.Items.Clear();

            foreach (Sale sale in sales) {
                foreach (DrinkSale drink in sale.drinks) {
                    ListViewItem item = new ListViewItem(sale.Id.ToString());

                    item.SubItems.Add(drink.DrinkName);
                    item.SubItems.Add(drink.quantity.ToString());
                    item.SubItems.Add(drink.revenue.ToString("0.00"));
                    item.SubItems.Add(drink.totalRevenue.ToString("0.00"));
                    item.SubItems.Add(drink.IsAlcoholic ? "Yes" : "No");

                    salesList.Items.Add(item);
                }
            }
        }
    }
}
