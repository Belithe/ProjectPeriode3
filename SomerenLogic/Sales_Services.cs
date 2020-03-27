using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic {
    public class Sales_Services {
        Sales_DAO sales_DAO = new Sales_DAO();

        public List<Sale> getSales() => sales_DAO.getAllSales();
        public Sale getSaleById(int id) => sales_DAO.getSaleById(id);
        public List<Sale> getSalesByDateRange(DateTime startDateTime, DateTime endDateTime) => sales_DAO.getSalesByDateRange(startDateTime, endDateTime);
    }
}
